using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Author: Bradyn Corkill
Date: 13/09/2018
 */
public class Shooting : MonoBehaviour {
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	float shootTime;
	public int speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// timer to set the amount shoot
		shootTime += Time.deltaTime;
		if(Input.GetKeyDown(KeyCode.Space) && shootTime > 0.5f)
		{
			Fire(); // call function
			shootTime = 0; // reset timer
		}
		
	}
	void Fire()
	{
		//creating the bullet prefab
		var bullet = (GameObject)Instantiate (bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
		
		// add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * speed;
		
	
	}

	
}
