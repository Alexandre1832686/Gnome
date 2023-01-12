using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Menu()
    {
        GameObject timer = GameObject.Find("Barre");
        Timer time = timer.GetComponent<Timer>();
        time.PauseTimer();
    }
}
