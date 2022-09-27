using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testercon : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right);
    }
}
