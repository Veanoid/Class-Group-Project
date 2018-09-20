//zackery welk
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonScript : MonoBehaviour {

    public GameObject pausePanel;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Pause()
    {
        Time.timeScale = 0.0f;
        pausePanel.SetActive(true);
    }
    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void Quit()
    {
        Application.Quit();
    }


}
