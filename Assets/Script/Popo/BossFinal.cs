using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFinal : Enemie
{
    private void Awake()
    {
        speed = 0.8f;
        hpMax = 6;
    }

    // Start is called before the first frame update
    void Start()
    {
        canBeAttacked = true;
        hpActu = hpMax;
        RefreshUI();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
