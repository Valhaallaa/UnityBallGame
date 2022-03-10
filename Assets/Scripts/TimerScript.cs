using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimerScript : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI TimeUI;
    float TimeV;

    /*void timer()
    {
        if (LevelComplete == 0)
        {
            TimeV = TimeV + Time.deltaTime;
            TimeUI.text = " " + TimeV;
        }
        else { }
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer();
    }
}
