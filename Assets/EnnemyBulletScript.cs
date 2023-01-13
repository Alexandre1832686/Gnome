using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

using UnityEngine;

public class EnnemyBulletScript : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    Vector3 direction;
    private float timer;
    // Start is called before the first frame update
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y ).normalized * force;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>2)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player.GetComponent<Gnome>().retirerVie();
        }
    }
    
    
}
