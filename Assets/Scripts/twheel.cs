using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twheel : MonoBehaviour
{
    Rigidbody2D rgb;
    [SerializeField]
    int speed=1;

    void Start()
    {
        rgb=GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rgb.AddForce(Vector2.up*speed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            rgb.AddForce(Vector2.down*speed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rgb.AddForce(Vector2.right*speed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            rgb.AddForce(Vector2.left*speed);
        }
    }

}
