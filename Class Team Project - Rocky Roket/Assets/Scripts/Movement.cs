using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Erik Camenzuli --------------------------------------------------------------------------------------------------------------
public class Movement : MonoBehaviour {

	public float Speed;
	public float RotationSpeed;
	private	Rigidbody rb; 	
	//public float JumpHight;
	//bool isJumping = false;
	//happens before start
	void awake()
	{
		Speed = 10.0f;
		RotationSpeed = 10.0f;
		//JumpHight = 2.0f;
		print("Started Function");
	}

	// Use this for initialization
	void Start () {
		print("Started Function");

		rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
			Move();
			// RotatedEQ();
	}

	// void RotatedEQ()
	// {
		
	// 	if (Input.GetKeyDown(KeyCode.E) )
	// 	{
	// 		transform.Rotate(new Vector3(0, 90, 0) * Speed * Time.deltaTime);
	// 		//Debug.Log("Player has Rotated 90 Degrees(Right)");
	// 	}

	// 	if (Input.GetKeyDown(KeyCode.Q) )
	// 	{
	// 		transform.Rotate(new Vector3(0, -90, 0) * Speed * Time.deltaTime);
	// 		//Debug.Log("Player has Rotated -90 Degrees(Left)");
	// 	}

	// }


	void Move()
	{
		float v = Input.GetAxisRaw("Vertical");
		float h = Input.GetAxisRaw("Horizontal");

		if (h > 0)
		{
		// transform.position += new Vector3(1.0f, 0.0f, 0.0f) * Speed * Time.deltaTime;
		transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);

		//Debug.Log(h);
		}
		if (h < 0)
		{
		// transform.position -= new Vector3(1.0f, 0.0f, 0.0f) * Speed * Time.deltaTime;
		transform.Rotate(Vector3.down * RotationSpeed * Time.deltaTime);

		//Debug.Log(h);
		}

		if (v > 0)
		{
			
			// transform.position += Vector3.forward * Speed * Time.deltaTime;
			rb.AddForce(gameObject.transform.forward * Speed);
			
		//Debug.Log(v);
		}
	// 	if (v < 0)
	// 	{
	// 	transform.position += Vector3.back * Speed * Time.deltaTime;
	// //	Debug.Log(v);
	// 	}

		//if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
	//	{
	//		this.GetComponent<Rigidbody>().velocity = new Vector3(0, JumpHight, 0);
		//	isJumping = true;
	//	}

		//if(this.GetComponent<Rigidbody>().velocity.y == 0)
	//	{
	//		isJumping = false;
	//	}

	}
}

