using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarreVieBoss : MonoBehaviour
{
    [SerializeField]Enemie boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(boss);
        if (boss != null)
        {
            
        }
    }

    private void afficherVie()
    {
        
    }
}
