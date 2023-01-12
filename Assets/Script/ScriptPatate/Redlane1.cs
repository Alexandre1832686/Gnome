using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redlane1 : MonoBehaviour
{
    public float speed = 100f;
    private Transform target;
    private float timer;
    

    void Start()
    {
       

        Vector2 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }


    
}
