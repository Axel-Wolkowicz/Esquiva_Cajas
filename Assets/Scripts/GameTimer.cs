using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
        [Header("UI")]
    public TMP_Text timerText;

    [Header("Settings")]
    public bool startAutomatically = true;

    private float elapsedTime = 0f;
    private bool isRunning = false;

    private void Start()
    {
        if (startAutomatically)
        {
            StartTimer();
        }

        UpdateTimerUI();
    }

    private void Update()
    {
        if (!isRunning)
            return;

        elapsedTime += Time.deltaTime;

        UpdateTimerUI();
    }

    public void StartTimer()
    {
        isRunning = true;
    }

    public void GameOver()
    {
        isRunning = false;
    }

    public void ResetTimer()
   {
        elapsedTime = 0f;
        isRunning = true;

        UpdateTimerUI();
    }

    public float GetCurrentTime()
    {
        return elapsedTime;
    }

    private void UpdateTimerUI()
    {
        int seconds = Mathf.FloorToInt(elapsedTime);
        int centiseconds = Mathf.FloorToInt((elapsedTime * 100) % 100);

        timerText.text = $"{seconds:00}:{centiseconds:00}";
    }
}
