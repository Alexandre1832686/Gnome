using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float Speed;
    Transform Target;
    float distanceToStop = 0.4f;
    Rigidbody2D rigidbody2d;
   

    // Start is called before the first frame update
    void Start()
    {
        Target = null;
        rigidbody2d = GetComponent<Rigidbody2D>();
        Speed = gameObject.GetComponent<Enemie>().speed;
    }

    // Update is called once per frame
    void Update()
    {
        





        if (Target != null)
        {
            if(Vector2.Distance(Target.position,transform.position)>=distanceToStop)
            {
                Vector3 toTarg = (Target.position - transform.position).normalized;
                // toTarg is now exactly what bullet.forwards would be if we aimed
                rigidbody2d.velocity = toTarg * Speed;
            }
            else
            {
                rigidbody2d.velocity = new Vector2(0, 0);
            }
        }
        else
        {
            rigidbody2d.velocity = new Vector2(0, 0);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
            Target = collision.transform;
    }
}

    
