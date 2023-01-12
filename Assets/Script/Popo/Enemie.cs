using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    [HideInInspector] public float hpMax;
    [HideInInspector] public float hpActu;
    [HideInInspector] public float speed;
    [HideInInspector] public bool canBeAttacked;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void TakeDammage(float dammage)
    {
        hpActu -= dammage;
        if (hpActu <= 0)
        {
            Die();
        }
        RefreshUI();
        
        canBeAttacked = false;
        Debug.Log("ok");
        StartCoroutine(Invincible());
    }

    protected void RefreshUI()
    {

    }

    IEnumerator Invincible()
    {
        if(gameObject.name == "Doight")
        {
            transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.red;
            yield return new WaitForSeconds(1);
            transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.white;
            canBeAttacked = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            yield return new WaitForSeconds(2);
            GetComponent<SpriteRenderer>().color = Color.white;
            canBeAttacked = true;
        }
        
    }

    void Die()
    {
        int i = Random.Range(0, 100);
        if(i>70)
        {
            
        }
        Destroy(gameObject);
    }


    virtual public bool Touche()
    {
        return true;
    }
    
}
