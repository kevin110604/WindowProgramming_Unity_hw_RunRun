﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData e)
    {
        SceneManager.LoadScene(0);
    }

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
