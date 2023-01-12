using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    [SerializeField] GameObject RedLane;
    private void Start()
    {
        RedLane.SetActive(false);
    }
    private void WalkTowardGnome()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
