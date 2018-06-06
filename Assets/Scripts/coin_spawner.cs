using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class coin_spawner : MonoBehaviour
{
    // Some variables
    public Transform coin;

    // Use this for initialization
    void Start ()
    {
        Transform[] c = new Transform[16];
        //System.Random rnd = new System.Random();
        int create_ornot=1;

        for (int i = 0; i < 15; i++)
        {
            //create_ornot = rnd.Next(0,2);
            if (create_ornot==1)
            {
                c[i] = Instantiate(coin);
                c[i].parent = transform;
                c[i].localPosition = Vector3.zero+Vector3.forward*i*4;
            }
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
