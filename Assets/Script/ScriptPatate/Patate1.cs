using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patate1 : Enemie
{
    public GameObject redLane;
    public Transform lanePos;//crée un objet vide et le placer où le projectile doit partir puis le glisser dans la partie du bulletPos 
    private Rigidbody2D rb;
    private float timer1;
    private GameObject player;
    private bool isRolling;
    public Transform stop;
    // Start is called before the first frame update
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
        
        // RefreshUI();peut être
    }


   private void OnTriggerEnter2D(Collider2D collision)
   {
        ShootPatate();
   }
    private void Update()
    {
        if(isRolling)
        {
            transform.position = Vector2.MoveTowards(transform.position, stop.position, speed* 5 * Time.deltaTime);
        }
    }
    private void ShootPatate()
    {
        Instantiate(redLane,lanePos.position, Quaternion.identity);
        if(timer1>2)
        {
            Destroy(redLane);
            isRolling = true;
        }
    }

}
