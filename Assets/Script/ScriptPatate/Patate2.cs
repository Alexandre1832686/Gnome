using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Patate2 : Enemie
{
    private GameObject redLane;
    [SerializeField] GameObject PieceGnomes;

    private bool isRolling;
    private Vector3 stoper;


    private void Awake()
    {
        speed = 1f;
        hpMax = 24;

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
        if (isRolling)
        {
            redLane.SetActive(false);
            transform.position = Vector2.MoveTowards(transform.position, stoper, speed * 5 * Time.deltaTime);//a prendre le stopper
            if (Vector2.Distance(transform.position, stoper) <= 0.01f)
            {
                redLane.SetActive(true);
                isRolling = false;
                StartCoroutine(WaitToShoot());
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            redLane.SetActive(true);
            StartCoroutine(WaitToShoot());
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }

    protected override void Die()
    {
        int i = Random.Range(0, 100);
        Instantiate(PieceGnomes, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    IEnumerator WaitToShoot()
    {
        
        yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
        stoper = redLane.GetComponent<Redlane1>().GetStopper();
        isRolling = true;
    }
}
