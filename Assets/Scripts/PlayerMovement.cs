using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{   
    public Game_Manager gm;
    public Rigidbody rb;
    public float sidewaysForce = 500f;
    public float forwardForce = 2000f;
    //public Vector3 stop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
         rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        // Add force
        if ( Input.GetKey("d") ) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( Input.GetKey("a") ) 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<Game_Manager>().EndGame();
        }
        // if ( Input.GetKey("w") ) 
        // {
        //     rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        // }
        // if ( Input.GetKey("s") ) 
        // {
        //     rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        // }

    }

    public void Slowdown ()
    {
        {
            forwardForce = 0;
            sidewaysForce = 0;
            // rb.velocity = rb.velocity * 0.01f * Time.deltaTime;
        }
    }
}
