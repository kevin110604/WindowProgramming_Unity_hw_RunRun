using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      //needed
using UnityEngine.EventSystems;         //needed

public class HelpButton : MonoBehaviour, IPointerClickHandler
{
    /* Button click function */
    public void OnPointerClick(PointerEventData e)
    {
        SceneManager.LoadScene(2);      //go to scene2
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
