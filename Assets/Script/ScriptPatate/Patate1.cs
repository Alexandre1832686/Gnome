using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Patate1 : Enemie
{
    private GameObject redLane;
    
    
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
        redLane.SetActive(false);

        
    }


  
    private void Update()
    {
         if(isRolling)
         {
            redLane.SetActive(false);
            transform.position = Vector2.MoveTowards(transform.position, stoper, speed * 5 * Time.deltaTime);//a prendre le stopper
            if(Vector2.Distance(transform.position,stoper)<=0.01f)
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

}
