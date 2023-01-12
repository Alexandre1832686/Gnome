using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textTimer;
    float Timers;
    int minutes = 0;
    private TimeSpan timePlaying;
    private float timePassed;
    // Start is called before the first frame update
    void Start()
    {
        Timers = 0;
        StartCoroutine(Temps());

    }

    public void BeginTimer()
    {
        timePassed = 0;


    }

    // Update is called once per frame
    void Update()
    {
        Timers += Time.deltaTime;

    }

    private IEnumerator Temps()
    {
        while (true)
        {
            timePassed += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(timePassed);
            textTimer.text = "Time  " + timePlaying.ToString("mm':'ss");

            yield return null;
        }
    }
}