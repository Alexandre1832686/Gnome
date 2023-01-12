using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float Speed;
    Transform Target;
    float distanceToStop = 2;
    Rigidbody2D rigidbody2d;
   [SerializeField] GameObject test;

    // Start is called before the first frame update
    void Start()
    {
        Target = null;
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            test.transform.position -= new Vector3(1, 0);
        }





        if (Target != null)
        {
            if(Vector2.Distance(Target.position,transform.position)>=distanceToStop)
            {
                Vector3 toTarg = (Target.position - transform.position).normalized;
                // toTarg is now exactly what bullet.forwards would be if we aimed
                rigidbody2d.velocity = toTarg * 3;
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
        Target = collision.transform;
    }
}

    
