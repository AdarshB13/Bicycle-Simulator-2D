using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcon : MonoBehaviour
{
    [SerializeField]
    Transform cycle;
    Vector3 despos;
    void FixedUpdate()
    {
        despos.x=Mathf.Clamp(cycle.position.x,-1f,Mathf.Infinity);
        despos.y=Mathf.Clamp(cycle.position.y,2f,Mathf.Infinity);
        despos.z=-10;
        transform.position=Vector3.Lerp(transform.position,despos,0.9f);
    }
}
