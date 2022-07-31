using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public Camera cam1;
    public Camera cam2;
    public Camera cam3;

    public float speed;

    void Start()
    {
        speed = 3f;
    }



    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }


        

        transform.position = pos;

        if (Input.GetKeyDown("c"))
        {
            Debug.Log(cam1.enabled);
            if (cam1.enabled)
            {
                cam2.enabled = true;
                cam1.enabled = false;
                cam3.enabled = false;
            }
            else if (cam2.enabled)
            {
                cam1.enabled = false;
                cam2.enabled = false;
                cam3.enabled = true;
            }
            else if (cam3.enabled)
            {
                cam3.enabled = false;
                cam1.enabled = true;
                cam2.enabled = false;
            }

        }
    }
}