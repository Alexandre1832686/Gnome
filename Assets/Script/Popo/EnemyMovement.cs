using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float Speed;
    [SerializeField] GameObject Target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Target != null)
            GetComponent<Rigidbody2D>().MovePosition(transform.position + Target.transform.position * Time.deltaTime * Speed);
    }
}

    
