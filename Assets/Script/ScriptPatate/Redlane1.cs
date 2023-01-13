using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redlane1 : MonoBehaviour
{
    public float speed = 100f;
    private Transform target;
    

    void Start()
    {
       
    }
    public Vector3 GetStopper()
    {
        return transform.GetChild(0).GetChild(0).position;
    }
    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        Vector2 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
    }


    
}
