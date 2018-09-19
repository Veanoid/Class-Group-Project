using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnCollision (Collision collision)
	{
		if(collision.gameObject.tag == "ship")
		{
			
		}
	}

	void damage()
	{
		
	}
}
