using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float speed = 10f;
    public float jumpPower = 10f;
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(new Vector3(0, jumpPower, 0));
        }

        if (Input.GetMouseButtonDown(0))
        {
            rigid.AddForce(new Vector3(0, jumpPower, 0));
        }
    }
}



/*
 
    
*/