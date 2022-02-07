
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenBar : MonoBehaviour
{
    [SerializeField] LevelManager levelManager;
    private float timeRemaining;
    private const float timerMax = 20f;
    public Slider slider;
    float seconds;

    void Start()
    {
        timeRemaining = timerMax;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = CalculateSliderValue();

        if(timeRemaining <= 0)
        {
            timeRemaining = 0;
            levelManager.LoadScene("Scene4");

        }
        else if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            seconds = timeRemaining % 60;
            Debug.Log(seconds);
        }
    }

    float CalculateSliderValue()
    {
        return (timeRemaining / timerMax);
    }

    public void IncreaseOxygen()
    {
        if (timeRemaining + 5 == timerMax)
        {
            timeRemaining = timerMax;
        }
        else
        {
            timeRemaining = timeRemaining + 2f;
        }
    }
}
