using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Patate1 : Enemie
{
    private GameObject redLane;
    Gnome gnome;
    GameObject perso;
    private bool isRolling;
    private Vector3 stoper;
    

    private void Awake()
    {
        speed = 0.5f;
        hpMax = 8;
        
    }

    private void Start()
    {
        canBeAttacked = true;
        hpActu = hpMax;
        isRolling = false;
        redLane = transform.GetChild(0).gameObject;
        stoper = redLane.GetComponent<Redlane1>().GetStopper();
        perso = GameObject.Find("Perso");
        gnome = perso.GetComponent<Gnome>();
        redLane.SetActive(false);
        StartCoroutine(attack());
    }



    private void Update()
    {
         if(isRolling)
         {
            redLane.SetActive(false);
            transform.position = Vector2.MoveTowards(transform.position, stoper, speed * 5 * Time.deltaTime);//a prendre le stopper
            if (Vector2.Distance(transform.position,stoper)<=0.01f)
            {
                redLane.SetActive(true);
                isRolling = false;
                StartCoroutine(WaitToShoot());
            }
         }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            redLane.SetActive(true);
            StartCoroutine(WaitToShoot());
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }


    
    IEnumerator WaitToShoot()
    {
        yield return new WaitForSeconds(2);
        stoper = redLane.GetComponent<Redlane1>().GetStopper();
        
        isRolling = true;
    }
    IEnumerator attack()
    {
        yield return new WaitForSeconds(1);
        if (Vector2.Distance(transform.position, perso.transform.position) <= 0.3)
        {
            gnome.retirerVie();
        }
        StartCoroutine(attack());
    }

}
