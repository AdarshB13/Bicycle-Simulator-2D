using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedel1 : MonoBehaviour
{
    Rigidbody2D rgb;
    [SerializeField]
    Rigidbody2D wrgb;

    void Start()
    {
        rgb=GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.touchCount>0)
        {
            if(Input.GetTouch(0).position.x<Screen.width*(2f/5f))
            {
                rgb.AddForce(Vector2.down*3);
            }
            else if(Input.GetTouch(0).position.x<Screen.width*(3f/5f) && wrgb.angularVelocity<0)
            {
                wrgb.AddTorque(15f);
            }
        }
    }
}
