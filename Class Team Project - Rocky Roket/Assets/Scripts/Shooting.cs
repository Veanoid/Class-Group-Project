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

	public int speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Fire();
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
