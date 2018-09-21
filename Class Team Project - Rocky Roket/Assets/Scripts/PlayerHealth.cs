//zackery welk
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public float timer;



	// Use this for initialization
	void Awake()
    {
        currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update()
    {
   
        //having the slider value = the health value
          healthSlider.value = currentHealth;
         
    }
    void OnCollisionEnter (Collision collision)
	{
		if(collision.gameObject.tag == "EnemyShip")
		{
			//Debug.Log(" Eenemy Ship Collision");
			//reduce the current health if the player hits the enemy
			currentHealth -= 10;
		}
		if(collision.gameObject.tag == "Asteroid")
		{
			//Debug.Log("Asteriod Collision");
			//reduce current health if the player hits an asteroid
			currentHealth -= 10;
		}
	}
    
}
