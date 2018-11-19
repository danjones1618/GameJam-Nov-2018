using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 5f;
    public float jumpForce = 10f;
    public bool isJump = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // W, A, S, D movments
        if (Input.GetKey("w")) {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s")) {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")) {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("d")) {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }

        //Jump
        if (Input.GetKeyDown("space") && isJump == false)
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
            isJump = true;
        }

        //Turning head


    }
    //jump update
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "ground")
        {
            isJump = false;
        }
    }
}


