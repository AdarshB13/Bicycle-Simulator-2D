using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintcon : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float speed,length;
    LineRenderer lr;
    Vector2 po;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        lr=GetComponent<LineRenderer>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up*speed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down*speed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left*speed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right*speed);
        }
    }

    void FixedUpdate()
    {
        po=transform.position;
        lr.SetPosition(0,transform.position);
        lr.SetPosition(1,(po-rb.velocity*length));
    }
}
