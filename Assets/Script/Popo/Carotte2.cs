using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carotte2 : Enemie
{
    private void Awake()
    {
        speed = 1.2f;
        hpMax = 25;
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
