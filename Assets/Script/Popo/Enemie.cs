using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    float hpMax;
    float hpActu;
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
            Destroy(gameObject);
        }
        RefreshUI();


    }

    void RefreshUI()
    {

    }

}
