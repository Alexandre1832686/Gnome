using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;//crée un objet vide et le placer où le projectile doit partir puis le glisser dans la partie du bulletPos 

    private float timer;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {

        float distance = Vector2.Distance(transform.position, player.transform.position);
        if(distance <4)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                timer = 0;
                Shoot();
            }
        }

       
    }

    protected void Shoot()
    {
        
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }


}
