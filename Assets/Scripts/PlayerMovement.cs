using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 5f;
    public float jumpForce = 10f;
    public bool isJump = false;

    public enum RotationAxes { MouseXandY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes axes = RotationAxes.MouseXandY;
    public float sensX = 3F;
    public float sensY = 3F;
    public float minX = -360F;
    public float maxX = 360F;
    public float minY = -60F;
    public float maxY = 60F;
    public float rotationY = 0f;
    public AudioClip footstep;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // W, A, S, D movments
        if (Input.GetKey("a")) {
            transform.Translate(-speed * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey("d")) {
            transform.Translate(speed * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey("w")) {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("s")) {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }

        //Jump
        if (Input.GetKeyDown("space") && isJump == false)
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
            isJump = true;
        }
        
        //Turning head
        if (axes == RotationAxes.MouseXandY)
        {
            float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensX;

            rotationY += Input.GetAxis("Mouse Y") * sensY;
            rotationY = Mathf.Clamp(rotationY, minY, maxY);

            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }
        else if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensX, 0);
        }
        else
        {
            rotationY += Input.GetAxis("Mouse Y") * sensY;
            rotationY = Mathf.Clamp(rotationY, minY, maxY);

            transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
        }

        
        //Ducking
        if (Input.GetKey("left ctrl")) transform.localScale = new Vector3(1, 0.5f, 1);
        else transform.localScale = new Vector3(1, 1, 1);
        
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


