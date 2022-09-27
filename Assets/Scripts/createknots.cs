using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createknots : MonoBehaviour
{
    [SerializeField]
    GameObject knot;
    Vector2 instpos;
    GameObject curins,preins;
    knotcon sjins;
    SpringJoint2D deactivate;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            preins=curins;
            instpos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            curins=Instantiate(knot,instpos,Quaternion.identity);
            if(preins!=null)
            {
                sjins=curins.GetComponent<knotcon>();
                sjins.settarget(preins.transform);
            }
            else
            {
                deactivate=curins.GetComponent<SpringJoint2D>();
                deactivate.enabled=false;
                sjins=curins.GetComponent<knotcon>();
                sjins.control=true;
            }
        }
    }
}
