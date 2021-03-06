﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Aurthor: Bradyn Corkill
Date: 6/9/18
 */

public class CameraControl : MonoBehaviour {

	public float m_DampTime = 0.2f; // aproimnt time for the camera to move
	public float m_ScreenEdgeBuffer = 4f; // keeps distanct from the edge and the ship
	public float m_MinSize = 6.5f; // won't zoom to close in
	/*[HideInInspector]*/ public Transform[] m_Targets; // setting the target of the ships

	private Camera m_Camera; // to reference the camera 
	private float m_ZoomSpeed; // the speed for how smooth the camera zooms
	private Vector3 m_MoveVelocity; // the velocity of the how smooth the postion moves
	private Vector3 m_DesiredPosition; // the postion the cmaera moves towards 

	// initialization before program runs
	private void Awake()
	{
		m_Camera =GetComponentInChildren<Camera>(); // set up the reference 
	}
	// initializating the update
	private void FixedUpdate()
	{
		Move(); // calling hte move function
		Zoom(); // calling the zoom function
	}

	private void Move()
	{
		FindAveragePosition(); // calling the findAvg function
		transform.position = Vector3.SmoothDamp(transform.position, m_DesiredPosition, ref m_MoveVelocity, m_DampTime); // snooth the camera from current pos to derisred pos
	}

	private void FindAveragePosition()
	{
		Vector3 averagePos = new Vector3(); // creating a new vector 3
		int numTargets = 0; // number of targets

		for(int i = 0; i < m_Targets.Length; i++) //looping throw the targets
		{
			if (!m_Targets[i].gameObject.activeSelf) // if the target is not active it will continue
			continue;

			averagePos += m_Targets[i].position; // add the tanks postion to avgpos
			numTargets++; // adding the tank to number of targets
		}
		if(numTargets > 0) // cheekign to see if move then 0 targets
		averagePos /= numTargets; // dividing the number of tanks avgpos

		averagePos.y = transform.position.y; // setting the y pos so it won't move 
		m_DesiredPosition = averagePos; // setting the desired pos to the avgpos
	}

	private void Zoom()
	{
		float requiredSize = FindRequiredSize(); // calling the function
		m_Camera.orthographicSize = Mathf.SmoothDamp(m_Camera.orthographicSize, requiredSize, ref m_ZoomSpeed, m_DampTime); // zooming the camera in and our smoothly 

	}

	private float FindRequiredSize()
	{
		Vector3 desiredLocalPos = transform.InverseTransformPoint(m_DesiredPosition); // find the postion the camera fig is moving towards in it's local space
		float size = 0f; // start the camera size calulation at zero
		for(int i = 0; i < m_Targets.Length; i++) // go through all the targets
		{
			if (!m_Targets[i].gameObject.activeSelf)// if they aren't active countinue on to the next target
			continue;
			else
			{
				// otherwise, find the position of the target in the camera loacl space
				Vector3 targetLocalPos = transform.InverseTransformPoint(m_Targets[i].position);

				// find the position of the target from the deired position of the camera local space
				Vector3 desiredPosToTarget = targetLocalPos - desiredLocalPos;

				// choose the largetest out of the current size and the distance of the tank 
				size = Mathf.Max (size, Mathf.Abs (desiredPosToTarget.y));

				// choos the largest out of the currnet size and the calculated size based on the tank
				size = Mathf.Max (size, Mathf.Abs (desiredPosToTarget.x) / m_Camera.aspect);
			}
		}

		// add the edge buffer to the size 
		size += m_ScreenEdgeBuffer;

		// make sure the cmaera size isn't below the minimum
		size = Mathf.Max (size, m_MinSize);

		return size;
	}

	public void SetStartPositionAndSize()
	{
		// find the desired position
		FindAveragePosition();
		// set the cameras position to the deired position without damping
		transform.position = m_DesiredPosition;
		// find and set the required size of the camera
		m_Camera.orthographicSize =FindRequiredSize();
	}

}
