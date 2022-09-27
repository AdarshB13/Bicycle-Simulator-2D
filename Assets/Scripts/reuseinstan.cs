using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reuseinstan : MonoBehaviour
{
    [SerializeField]
    GameObject bot;
    GameObject[] goarray;
    [SerializeField]
    int j;
    bool use;

    void Start()
    {
        goarray=new GameObject[10];
        for (int i=0;i<goarray.Length;i++)
        {
            goarray[i]=Instantiate(bot,transform.position,Quaternion.identity);
            goarray[i].SetActive(false);
        }   
        use=true;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            goarray[j].SetActive(use);
            j+=1;
            if(j>goarray.Length-1)
            {
                use=!use;
                j=0;
            }
        }
    }
}
