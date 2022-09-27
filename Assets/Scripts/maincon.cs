using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincon : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float speed;
    ParticleSystem.Particle pa;
    float vtolt;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();  
        pa=new ParticleSystem.Particle();  
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
        vtolt=(rb.velocity.magnitude/10);
        pa.remainingLifetime=vtolt;
    }
}
