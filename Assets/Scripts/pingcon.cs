using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pingcon : MonoBehaviour
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
        rb.AddForce(new Vector2(0.1f,0.8f)*speed);
    }

    void FixedUpdate()
    {
        po=transform.position;
        lr.SetPosition(0,transform.position);
        lr.SetPosition(1,(po-rb.velocity*length));
    }
}
