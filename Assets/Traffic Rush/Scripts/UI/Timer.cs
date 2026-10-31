using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timeValue = 90;

    public TMPro.TextMeshProUGUI timerTextMeshPro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        DisplayTimer(timeValue);

    }

    private void DisplayTimer(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); // Calculating Mintues //

        float seconds = Mathf.FloorToInt(timeToDisplay % 60); // Calculating Seconds //

        timerTextMeshPro.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Displaying the Timer in Text Format by Minutes / Seconds / Minutes / Seconds //
    }
}
