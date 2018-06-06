using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Some variables
    public Transform man;
    //public float moving_amount;

    // Use this for initialization
    void Start ()
    {
        //transform.position = man.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = man.position+3*Vector3.up+12*Vector3.back;

        /*
        if (man.position.x > transform.position.x)
        {
            transform.position += moving_amount * Time.deltaTime * Vector3.forward;
        }
        if (man.position.x < transform.position.x)
        {
            transform.position += moving_amount * Time.deltaTime * Vector3.back;
        }
        if (man.position.z > transform.position.z)
        {
            transform.position += moving_amount * Time.deltaTime * Vector3.left;
        }
        if (man.position.z < transform.position.z)
        {
            transform.position += moving_amount * Time.deltaTime * Vector3.right;
        }
        if (man.position.x == transform.position.x)
        {
            transform.position = man.position;
        }
        */
    }
}
