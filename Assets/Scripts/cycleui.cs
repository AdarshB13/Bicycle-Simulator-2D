using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class cycleui : MonoBehaviour
{
    [SerializeField]
    float ftime=10f;
    void Update()
    {
       ftime-=Time.deltaTime;
       if(ftime<5f)
       {
          gameObject.GetComponent<TMPro.TextMeshProUGUI>().text="              esc - Main Menu";
       }
       if(ftime<0f)
       {
          gameObject.SetActive(false);
       }
    }
}
