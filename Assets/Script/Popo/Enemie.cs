using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    float hpMax;
    float hpActu;
    public Material invincibleMaterial;
    public bool canBeAttacked;


    // Start is called before the first frame update
    void Start()
    {
        hpMax = 20;
        hpActu = hpMax;
        RefreshUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDammage(float dammage)
    {
        hpActu -= dammage;
        if (hpActu <= 0)
        {
            Die();
        }
        RefreshUI();
        
        canBeAttacked = false;
        StartCoroutine(Invincible());
    }

    void RefreshUI()
    {

    }

    IEnumerator Invincible()
    {
        Material myMaterial = GetComponent<SpriteRenderer>().material;
        GetComponent<SpriteRenderer>().material = invincibleMaterial;
        yield return new WaitForSeconds(2);
        GetComponent<SpriteRenderer>().material = myMaterial;
        canBeAttacked = true;
    }

    void Die()
    {
        int i = Random.Range(0, 100);
        if(i>70)
        {
            Instantiate((GameObject)Resources.Load("Prefab/Piece") as GameObject, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
