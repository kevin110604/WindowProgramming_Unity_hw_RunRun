using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                   //needed

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Animator))]

public class Controller : MonoBehaviour
{
    // Some variables
    Rigidbody rb;
    Animator at;
    public float moving_amount;
    public float jump_amount;
    private bool on_ground;
    //float x = 0, z = 0;               //raycast position
    public Text win_text;
    public Text gameover_text;
    public AudioSource JumpSound;

    // Use this for initialization
    void Start ()
    {
        //transform.position = Vector3.zero;
        rb = GetComponent<Rigidbody>();
        at = GetComponent<Animator>();
        win_text.enabled = false;
        gameover_text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        at.SetFloat("speed", 0f);

        if (transform.position.y < -35)     //game over
            gameover_text.enabled = true;

        // WSAD
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += moving_amount * Time.deltaTime * Vector3.forward;
            rb.AddForce(moving_amount * Time.deltaTime * Vector3.forward);
            at.SetFloat("speed", moving_amount);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.position += moving_amount * Time.deltaTime * Vector3.back;
            rb.AddForce(moving_amount * Time.deltaTime * Vector3.back);
            at.SetFloat("speed", moving_amount);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position += moving_amount * Time.deltaTime * Vector3.left;
            rb.AddForce(moving_amount * Time.deltaTime * Vector3.left);
            at.SetFloat("speed", moving_amount);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += moving_amount * Time.deltaTime * Vector3.right;
            rb.AddForce(moving_amount * Time.deltaTime * Vector3.right);
            at.SetFloat("speed", moving_amount);
        }

        // Jump
        if (Input.GetKey(KeyCode.J))
        {
            if (on_ground)
            {
                //transform.position += jump_amount * Time.deltaTime * Vector3.up;
                JumpSound.Play();
                rb.AddForce(jump_amount * Time.deltaTime * Vector3.up);
                at.SetFloat("speed", jump_amount);
            }
            on_ground = false;
        }

        /*
        if (Input.GetMouseButtonDown(0))
        {
            Ray mouse_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit ray_cast_hit;
            if (Physics.Raycast(mouse_ray, out ray_cast_hit))
            {
                Debug.Log(ray_cast_hit.transform.name);
            }

            //if (ray_cast_hit.transform.name== "big_module_01_floor")
            //{
            x = ray_cast_hit.point.x;
            z = ray_cast_hit.point.z;
            //}
        }
        
        if (x > transform.position.x+0.5)
        {
            //rb.AddForce(moving_force_amount * Time.deltaTime * Vector3.right);
            transform.position += moving_amount * Time.deltaTime * Vector3.right;
            at.SetFloat("speed", moving_amount);
        }
        else if (x < transform.position.x-0.5)
        { 
            //rb.AddForce(moving_force_amount * Time.deltaTime * Vector3.left);
            transform.position += moving_amount * Time.deltaTime * Vector3.left;
            at.SetFloat("speed", moving_amount);
        }
        if (z > transform.position.z+0.5)
        {
            //rb.AddForce(moving_force_amount * Time.deltaTime * Vector3.forward);
            transform.position += moving_amount * Time.deltaTime * Vector3.forward;
            at.SetFloat("speed", moving_amount);
        }
        else if (z < transform.position.z-0.5)
        {
            //rb.AddForce(moving_force_amount * Time.deltaTime * Vector3.back);
            transform.position += moving_amount * Time.deltaTime * Vector3.back;
            at.SetFloat("speed", moving_amount);
        }
        */
    }

    void OnCollisionEnter(Collision c)
    {
        //Debug.Log("collide");
    }

    void OnCollisionStay(Collision c)
    {
        if (c.transform.name == "big_module_01" || c.transform.name == "big_module_01_floor" ||
            c.transform.name == "wooden_bridge_01" ||
            c.transform.name == "big_module_04_02" || c.transform.name == "big_module_04_02_floor" ||
            c.transform.name == "big_module_04" || c.transform.name == "big_module_04_floor" ||
            c.transform.name == "big_module_04r" ||
            c.transform.name == "steps_rock_01" || c.transform.name == "steps_rock_02" ||
            c.transform.name == "steps_rock_03" || c.transform.name == "steps_rock_04")
        {
            //Debug.Log("onGround");
            on_ground = true;
        }
        else
        {
            on_ground = false;
        }

        if (c.transform.name == "big_module_04r" || c.transform.name == "big_module_04_floor_r")
        {
            moving_amount = 4000;
        }
        else if (c.transform.name == "steps_rock_04" )
        {
            moving_amount = 0;
            rb.AddForce(4000 * Time.deltaTime * Vector3.back);
        }
        else
        {
            moving_amount = 750;
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.transform.name == "GoalZone")
        {
            //Debug.Log("Goal!");
            win_text.enabled = true;
        }
    }
}
