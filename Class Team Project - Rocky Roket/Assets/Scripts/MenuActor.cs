//zackery welk
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuActor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadScene(string scene_Name)
    {
		//loads the scene that is being called and setting the time back to normal
        SceneManager.LoadScene(scene_Name);
        Time.timeScale = 1.0f;
    }
}
