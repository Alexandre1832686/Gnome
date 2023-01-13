using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MaÏs : Enemie
{
    GameObject perso;
    Gnome gnome;
    private void Awake()
    {
        
        hpMax = 5;
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
