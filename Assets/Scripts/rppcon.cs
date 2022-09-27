using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rppcon : MonoBehaviour
{
    LineRenderer lr;
    int count;
    [SerializeField]
    int collcount;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(count<collcount)
        {
            count+=1;
            lr=GetComponent<LineRenderer>();
            lr.positionCount=count;
            lr.SetPosition(count-1,transform.position);
        }
        else
        {
            count+=1;
            lr.positionCount=count;
            lr.SetPosition(count-1,transform.position);
            Destroy(gameObject);
        }
    }
}
