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
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            DirY = "N";
            ChangeAnimation();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            DirY = "S";
            ChangeAnimation();

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            DirX = "W";
            ChangeAnimation();

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            DirX = "E";
            ChangeAnimation();

        }

        if(mouvement.x <= 0.1f && mouvement.x >= -0.1f && mouvement.y <= 0.1f && mouvement.y >= -0.1f)
        {
            ChangeAnimation();
        }
    }

    void ChangeAnimation()
    {
        if (mouvement.x >= 0.1f || mouvement.x <= -0.1f || mouvement.y >= 0.1f || mouvement.y <= -0.1f)
        {
            if (DirY + DirX == "SE")
            {
                animator.Play("Base Layer.Wallk SE", 0, 0.833f);
            }
            if (DirY + DirX == "SW")
            {
                animator.Play("Base Layer.Wallk SW", 0, 0.833f);
            }
            if (DirY + DirX == "NE")
            {
                animator.Play("Base Layer.Wallk NE", 0, 0.833f);
            }
            if (DirY + DirX == "NW")
            {
                animator.Play("Base Layer.Walk NW", 0, 0.833f);
            }
        }
        else
        {
            if (DirY + DirX == "SE")
            {
                animator.Play("Idle SE");
            }
            if (DirY + DirX == "SW")
            {
                animator.Play("Idle SW");
            }
            if (DirY + DirX == "NE")
            {
                animator.Play("Idle NE");
            }
            if (DirY + DirX == "NW")
            {
                animator.Play("Idle NW");
            }
        }
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
    }
}
