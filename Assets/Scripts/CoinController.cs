using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public Vector3 rotation_dir;
    public float rotation_amount;

    // Use this for initialization
    void Start ()
    {
        GetComponent<Rigidbody>().AddTorque(rotation_amount * rotation_dir);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
