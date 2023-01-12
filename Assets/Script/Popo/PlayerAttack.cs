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
        isAttacking = false;
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
                StartCoroutine(attack());
                
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Enemie" && collision.isTrigger == false)
        {
            Debug.Log("ok3");
            if (collision.GetComponent<Enemie>().canBeAttacked)
            {
                Debug.Log("ok2");
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
