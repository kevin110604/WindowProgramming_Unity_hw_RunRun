using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ExitButton : MonoBehaviour, IPointerClickHandler
{
    /* Button click function */
    public void OnPointerClick(PointerEventData e)
    {
        Application.Quit();             //exit the game
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
