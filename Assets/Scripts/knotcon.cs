using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knotcon : MonoBehaviour
{
    SpringJoint2D sj;
    bool connected;
    Transform target;
    public bool control;
    Vector2 mousepos;
    Rigidbody2D rb;
    [SerializeField]
    float speed;
    
    void Start()
    {
        sj=GetComponent<SpringJoint2D>();
    }

    void FixedUpdate()
    {
        if(connected)
        {
            sj.connectedAnchor=target.position;
        }
    }

    void Update()
    {
        if(control)
        {
            if(Input.GetMouseButtonDown(1))
            {
                mousepos=Camera.main.ScreenToWorldPoint(Input.mousePosition);  
            }
            rb=GetComponent<Rigidbody2D>();
            rb.MovePosition(Vector2.Lerp(transform.position,mousepos,speed));
        }
    }

    public void settarget(Transform tar)
    {
        target=tar;
        connected=true;
    }
 
}
