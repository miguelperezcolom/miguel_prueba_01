using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var rigidBody = GetComponent<Rigidbody2D>();


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //transform.Translate(Vector3.left);
            rigidBody.AddForce(Vector2.left * 200);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
//            transform.Translate(Vector3.right);
            rigidBody.AddForce(Vector2.right * 100);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //transform.Translate(Vector3.up);
            rigidBody.AddForce(Vector2.up * 200);
        }
        
        
    }
}
