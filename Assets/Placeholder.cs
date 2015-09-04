using UnityEngine;
using System.Collections;

public class Placeholder : MonoBehaviour 
{
    public float Timer = 0;

    // Use this for initialization
    void Start()
    {
        //Time.timeScale *= 60;
    }

    // Update is called once per frame
    void Update()
    {
        Timer = Timer - Time.deltaTime;
        LogTime(Timer);
    }

    private void LogTime(float seconds)
    {
        if (seconds > 0)
        {
            seconds = Mathf.Floor(seconds);

            float minutes = seconds / 60;
            minutes = Mathf.Floor(minutes);
            seconds = seconds - minutes * 60;

            float hours = minutes / 60;
            hours = Mathf.Floor(hours);
            minutes = minutes - hours * 60;

            Debug.Log(hours + "h " + minutes + "m " + seconds + "s");
        }
        else
        {
            string alarmText = "";
            float overtime = -seconds;
            while (overtime > 0)
            {
                alarmText += "beep ";
                overtime -= 5;
            }
            if (Mathf.RoundToInt(Time.time)%2==0)
            {
                alarmText = "<color=red>" + alarmText + "</color>";
            }
            Debug.Log(alarmText);
        }
    }
}
