using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collions : MonoBehaviour 
{
	private EnemyHealth m_enemyHealth;
	private PlayerHealth m_playerHealth;
	// Use this for initialization
	void Start () {
		m_enemyHealth = GameObject.FindGameObjectWithTag("EnemyShip").GetComponent<EnemyHealth>();
		m_playerHealth = GameObject.FindGameObjectWithTag("Ship").GetComponent<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnTriggerEnter (Collider collision)
	{
		if(collision.gameObject.tag == "Ship")
		{
			Debug.Log("Ship Collision");
			m_playerHealth.currentHealth -= 20;
			Destroy(this.gameObject);
		}
		if(collision.gameObject.tag == "EnemyShip")
		{
			Debug.Log("Enemy Ship Collision");

			m_enemyHealth.currentHealth -= 20;
			Destroy(this.gameObject);

		}
		if(collision.gameObject.tag == "Asteroid")
		{
			Debug.Log("Asteriod Collision");
			Destroy(this.gameObject);

		}
		if(collision.gameObject.tag == "Boundary")
		{
			
			Destroy(this.gameObject);

		}

	}
	
}
