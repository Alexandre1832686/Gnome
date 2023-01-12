using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    
    public float mouveSpeed = 5f;
    public Rigidbody2D rb;
    //public Camera cam;
    Vector2 mouvement;
   // Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mouvement.x = Input.GetAxis("Horizontal");
        mouvement.y = Input.GetAxis("Vertical");

        //GetComponent<Rigidbody2D>().MovePosition(transform.position + new Vector3(x, y) * Time.fixedDeltaTime * Speed);
       
       //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate()
    {
         rb.MovePosition(rb.position + mouvement * mouveSpeed * Time.fixedDeltaTime);

        //Vector2 lookDir=mousePos-rb.position;
        //float angle = Mathf.Atan2(lookDir.y, lookDir.x)*Mathf.Rad2Deg -90f;
       // transform.GetChild(0).GetComponent<Rigidbody2D>().rotation =angle;
    }
}
