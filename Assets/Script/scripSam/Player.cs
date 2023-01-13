using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    string DirX;
    string DirY;
    
    public float mouveSpeed = 5f;
    Rigidbody2D rb;
    Vector2 mouvement;
    Vector2 mousePos;
    Animator animator;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        DirX = "E";
        DirY = "S";
        animator = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        mouvement.x = Input.GetAxis("Horizontal");
        mouvement.y = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + mouvement * mouveSpeed * Time.fixedDeltaTime);

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, angle);

        if (Input.GetKeyDown(KeyCode.W))
        {
            DirY = "N";
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            DirY = "S";
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            DirX = "W";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            DirX = "E";
        }

        if (rb.velocity.x >= 0.1f || rb.velocity.y >= 0.1f)
        {
            if (DirX + "" + DirY == "SE")
            {
                animator.Play("WalkSE");
            }
            if (DirX + "" + DirY == "SW")
            {
                animator.Play("WalkSW");
            }
            if (DirX + "" + DirY == "NE")
            {
                animator.Play("WalkNE");
            }
            if (DirX + "" + DirY == "NW")
            {
                animator.Play("WalkNW");
            }
        }
        else
        {
            if (DirX + "" + DirY == "SE")
            {
                animator.Play("IdleSE");
            }
            if (DirX + "" + DirY == "SW")
            {
                animator.Play("IdleSW");
            }
            if (DirX + "" + DirY == "NE")
            {
                animator.Play("IdleNE");
            }
            if (DirX + "" + DirY == "NW")
            {
                animator.Play("IdleNW");
            }
        }


    }
}
