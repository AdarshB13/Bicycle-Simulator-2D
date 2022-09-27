using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pedel2 : MonoBehaviour
{
    Rigidbody2D rgb;

    void Start()
    {
        rgb=GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.touchCount>0)
        {
            if(Input.GetTouch(0).position.x>Screen.width*(3f/5f))
            {
                rgb.AddForce(Vector2.down*3);
            }
        }
    }

}
