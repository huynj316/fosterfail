using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayTimer : MonoBehaviour
{
    public int DayCount = 1;
    public string Phase = "PreRound";
    public float StartTime = 600f;
    private float CurrentTime;
    public string niceTime = "10:00";

    public Transform TimerText;

    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = StartTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            if (Phase == "PreRound") {
                Phase = "InRound";
            } else if (Phase == "EndRound")
            {
                DayCount++;
                ResetTimer();
                Phase = "PreRound";
            }
        }

        if (Phase == "InRound")
        {
            if (CurrentTime > 0f)
            {
                CurrentTime -= Time.deltaTime;
                int minutes = Mathf.FloorToInt(CurrentTime / 60F);
                int seconds = Mathf.FloorToInt(CurrentTime - minutes * 60);
                niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            }
            else
            {
                niceTime = "0:00";
                //Display Win UI
                Phase = "EndRound";
            }
        }

        TimerText.GetComponent<Text>().text = niceTime;
    }

    void ResetTimer()
    {
        CurrentTime = StartTime;
    }
}
