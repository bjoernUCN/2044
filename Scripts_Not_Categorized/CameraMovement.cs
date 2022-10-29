using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed;



    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-transform.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * Time.deltaTime * speed);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(-transform.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.C))
        {
            transform.Translate(transform.up * Time.deltaTime * speed);
        }

    }
}
