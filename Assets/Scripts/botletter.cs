using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botletter : MonoBehaviour
{
    [SerializeField]
    GameObject bot;
    [SerializeField]
    float speed;
    [SerializeField]
    int botcount;
    Vector3 mousepos;
    float timer;
    GameObject botinstance;
    SpriteRenderer botsr;

    void FixedUpdate()
    {
        timer-=Time.deltaTime;
        if(timer<0)
        {
            mousepos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousepos.z=0;
            botinstance=Instantiate(bot,mousepos,Quaternion.identity);
            botsr=botinstance.GetComponent<SpriteRenderer>();
            botsr.color=new Color(Random.value,Random.value,Random.value);
            timer=0.05f;
            botcount+=1;
        }
    }
}
