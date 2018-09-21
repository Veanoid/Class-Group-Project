//zackery welk
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
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
		if(collision.gameObject.tag == "Ship")
		{
			//Debug.Log(" Eenemy Ship Collision");
            //reduce the current health if the enemy hits the player
			currentHealth -= 10;
		}
		if(collision.gameObject.tag == "Asteroid")
		{
			//Debug.Log("Asteriod Collision");
            //reduce the current health if the enemy hits an asteroid
			currentHealth -= 10;
		}
	}
    
}
