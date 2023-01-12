using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    
    public float mouveSpeed = 5f;
    Rigidbody2D rb;
    Vector2 mouvement;
    Vector2 mousePos;
    
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }
    void FixedUpdate()
    {
        mouvement.x = Input.GetAxis("Horizontal");
        mouvement.y = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + mouvement * mouveSpeed * Time.fixedDeltaTime);

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir =mousePos-rb.position;
       float angle = Mathf.Atan2(lookDir.y, lookDir.x)*Mathf.Rad2Deg -90f;
       transform.GetChild(0).transform.rotation = Quaternion.Euler(0,0, angle);
    }

    
}
