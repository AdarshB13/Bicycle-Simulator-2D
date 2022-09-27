using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lasercon : MonoBehaviour
{
    Vector3 mousepos,relative;
    float angle;
    [SerializeField]
    GameObject laser;
    Rigidbody2D rgb;
    [SerializeField]
    float speed;
    GameObject rppinstance;
    [SerializeField]
    GameObject cpoint;
    [SerializeField]
    float timedelay;
    float timer;
    bool can;

    void Start()
    {
        timer=timedelay;
    }

    void Update()
    {
        mousepos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        relative=mousepos-transform.position;
        angle=Mathf.Atan2(relative.y,relative.x)*Mathf.Rad2Deg;
        transform.rotation=Quaternion.AngleAxis(angle,new Vector3(0,0,1));
        timer-=Time.deltaTime;
        if(timer<0)
        {
            can=true;
        }
        if(can)
        {
            rppinstance=Instantiate(laser,cpoint.transform.position,transform.rotation);
            rgb=rppinstance.GetComponent<Rigidbody2D>();
            rgb.AddForce(relative.normalized*speed);
            can=false;
            timer=timedelay;
        }
    }
}
