using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textTimer;
    [SerializeField] Canvas Menu_Pause;
    float Timers;
    int minutes = 0;
    bool pause = true;
    private TimeSpan timePlaying;
    private float timePassed;
    // Start is called before the first frame update
    void Start()
    {
        Timers = 0;
        Menu_Pause.enabled = false;
        StartCoroutine(Temps());

    }

    public void PauseTimer()
    {
        if (pause) 
        {
            pause = false; 
            Time.timeScale = 0; 
            Menu_Pause.enabled = true;
        }
        else
        {
            pause = true;
            Time.timeScale = 1;
            Menu_Pause.enabled = false;
            StartCoroutine(Temps());
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        Timers += Time.deltaTime;

    }

    public IEnumerator Temps()
    {
        while (pause == true)
        {
            timePassed += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(timePassed);
            textTimer.text = "Time  " + timePlaying.ToString("mm':'ss");

            yield return null;
        }
    }
}