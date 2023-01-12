using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMagnet : MonoBehaviour
{
    [SerializeField] GameObject player;
    
    float timestamp;
    bool flyToPlayer;
    Vector2 playerDirection;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("in zone");
            
    }

   
}
