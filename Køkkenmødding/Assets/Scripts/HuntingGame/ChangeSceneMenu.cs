﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSceneMenu : MonoBehaviour {
    public Button button;
	// Use this for initialization
	void Start () {
        button.onClick.AddListener(delegate { click(); });
	}

    void click()
    {
		Debug.Log (Time.timeSinceLevelLoad);
        SceneManager.LoadScene("Midding"); //if main scene name change change here aswell.
    }
  
}
