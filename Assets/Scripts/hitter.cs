using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitter : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float speed;
    [SerializeField]
    Vector2 xstart;
    [SerializeField]
    int col,row;
    [SerializeField]
    GameObject blocker;
    GameObject instance;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        for(int j=0;j<col;j++)
        {
            for(int i=0;i<row;i++)
            {
                instance=Instantiate(blocker,xstart,Quaternion.identity);
                xstart.x+=1f;
            }
            xstart.x-=row;
            xstart.y-=1f;
        }
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left*speed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right*speed);
        }
    }
}
