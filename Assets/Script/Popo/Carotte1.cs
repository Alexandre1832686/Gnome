using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carotte1 : Enemie
{
    GameObject perso;
    Gnome gnome;
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
        perso = GameObject.Find("Perso");
        gnome = perso.GetComponent<Gnome>();
        StartCoroutine(attack());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator attack()
    {
            yield return new WaitForSecondsRealtime(1);
        if(Vector2.Distance(transform.position,perso.transform.position)<=0.4)
        {
           gnome.retirerVie();
        }
        StartCoroutine(attack());
    }


}
