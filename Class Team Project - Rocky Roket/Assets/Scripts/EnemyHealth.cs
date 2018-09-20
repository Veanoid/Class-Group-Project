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
       
        healthSlider.value = currentHealth;
    
    }
        void OnCollisionEnter (Collision collision)
	{
		if(collision.gameObject.tag == "Ship")
		{
			Debug.Log(" Eenemy Ship Collision");
			currentHealth -= 10;
		}
		if(collision.gameObject.tag == "Asteroid")
		{
			Debug.Log("Asteriod Collision");
			currentHealth -= 10;
		}
	}
    
}
