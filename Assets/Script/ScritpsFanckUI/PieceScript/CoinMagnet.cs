using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMagnet : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speed = 1.5f ;
    int nbPiece=0;
    float timestamp;
    bool flyToPlayer=false;
    Vector2 playerDirection;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            flyToPlayer = true;
        }
        
    }
    private void Update()
    {
        if(flyToPlayer)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }

}