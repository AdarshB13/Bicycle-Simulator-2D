using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectablecon : MonoBehaviour
{
    Vector2 mp,cp,po;
    void Update() {
        if(Input.GetMouseButton(0)) {
            mp=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            po=transform.position;
            cp=po-mp;
        }
    }

    void FixedUpdate() {
        if(cp.x<0.5f && cp.y<0.5f){
                transform.position=mp;
            }
    }
}
