using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Author: Bradyn Corkill
date: 21/09/18
 */
public class WinLose : MonoBehaviour
 {
 public GameObject WinScreen;
public GameObject LoseScreen;
public PlayerHealth m_playerHealth;
public EnemyHealth m_enemyHealth;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		// if the enemy health reaches 0 or less the player wins 
		if(m_enemyHealth.currentHealth <= 0)
		{
			Time.timeScale = 0.0f;
			WinScreen.SetActive(true);
		}
		// if the players health raeches 0 or less the enemy wins 
		if(m_playerHealth.currentHealth <= 0)
		{
			Time.timeScale = 0.0f;
			LoseScreen.SetActive(true);
		}
		
	}
}
