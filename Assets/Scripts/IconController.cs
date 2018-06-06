using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconController : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        /* When you go to other scene, those gameobject in the
         * current scene would be destroyed.
         * If you want to preserve some gameobjects, you need to add...
         */
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
