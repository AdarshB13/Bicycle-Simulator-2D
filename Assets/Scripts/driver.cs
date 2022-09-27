using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    [SerializeField]
    GameObject clank;
    Rigidbody2D rgb;
    [SerializeField]
    Rigidbody2D wrgb;
    int initialpos;
    [SerializeField]
    GameObject mg;
    meshgen mgs;
    [SerializeField]
    GameObject speedmeter;

    void Start()
    {
        rgb=clank.GetComponent<Rigidbody2D>();
        initialpos=Mathf.RoundToInt(transform.position.x);
    }

    void Update()
    {
        transform.eulerAngles=new Vector3(0,0,clank.transform.eulerAngles.z);
        if(Input.GetKey(KeyCode.B) && wrgb.angularVelocity<0)
        {
            wrgb.AddTorque(5f);
        }
    }

    void FixedUpdate()
    {
        wrgb.AddTorque(rgb.angularVelocity/50f);
        int curpos=Mathf.RoundToInt(transform.position.x);
        if(curpos>initialpos)
        {
            initialpos=curpos;
            mgs=mg.GetComponent<meshgen>();
            mgs.progen();
        }
        float rvelocity=Mathf.Round(wrgb.velocity.magnitude*10f)*0.1f;
        speedmeter.GetComponent<TMPro.TextMeshProUGUI>().text="Speed-"+rvelocity+"m/s";
    }
}