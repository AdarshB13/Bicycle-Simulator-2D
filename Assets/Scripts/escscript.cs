using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class escscript : MonoBehaviour
{
    Button btn;
    [SerializeField]
    GameObject exitmenu;

    void Start()
    {
        btn=GetComponent<Button>();
        btn.onClick.AddListener(exit);
    }

    void exit()
    {
        Time.timeScale=0;
        exitmenu.SetActive(true);
    }
}
