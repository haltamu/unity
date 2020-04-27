using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float flag;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
        flag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if(flag == 0)
            {
                speed = 5;
            }
            else if (flag == 1)
            {
                speed = 10;
            }
            rb.AddForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (flag == 0)
            {
                speed = -5;
            }
            else if (flag == 1)
            {
                speed = -10;
            }
            rb.AddForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (flag == 0)
            {
                speed = 5;
            }
            else if (flag == 1)
            {
                speed = 10;
            }
            rb.AddForce(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (flag == 0)
            {
                speed = -5;
            }
            else if (flag == 1)
            {
                speed = -10;
            }
            rb.AddForce(speed, 0, 0);
        }
    }
    void OnCollisionEnter(Collision hit)
    {
        if(hit.gameObject.tag == "speedgr")
        {
            flag = 1;
        }
    }

}
