using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class breaksc : MonoBehaviour
{
    Button btn;

    void Start()
    {
        btn=GetComponent<Button>();
        btn.onClick.AddListener(de);
    }

    void de()
    {
        Debug.Log("pressed");
    }
}
