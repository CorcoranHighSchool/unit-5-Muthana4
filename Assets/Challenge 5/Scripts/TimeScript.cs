using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimeScript : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public TextMeshProUGUI TimerTxt;
    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time is UP!");
                TimeLeft = 0;
                TimerOn = false;
            }
            updateTimer();
        }

        
    }

    void updateTimer()
    {
        TimerTxt.text = "time remaining" + Mathf.Round(TimeLeft);
    }
}
