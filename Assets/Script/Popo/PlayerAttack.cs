using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    float Dammage;

    bool isAttacking;
    // Start is called before the first frame update
    void Start()
    {
        Dammage = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isAttacking)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isAttacking = true;
                
            }
        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Enemie" && collision.isTrigger == false)
        {
            if(collision.GetComponent<Enemie>().canBeAttacked)
            {
                if (isAttacking)
                {
                    collision.GetComponent<Enemie>().TakeDammage(Dammage);
                    isAttacking = false;
                }
            }
        }
    }

    IEnumerator attack()
    {
        yield return new WaitForSeconds(1);
        isAttacking = false;
    }
}
