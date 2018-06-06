using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      //needed
using UnityEngine.EventSystems;         //needed

public class StartButton : MonoBehaviour, IPointerClickHandler
{
    /* Button click function */
    public void OnPointerClick(PointerEventData e)
    {
        SceneManager.LoadScene(1);      //go to scene1
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
