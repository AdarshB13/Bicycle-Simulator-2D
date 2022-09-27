using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resumsc : MonoBehaviour
{
    Button btn;
    [SerializeField]
    GameObject exitmenu;
    void Start()
    {
        btn=GetComponent<Button>();
        btn.onClick.AddListener(resume);
    }

    void resume()
    {
        Time.timeScale=1;
        exitmenu.SetActive(false);
    }
}
