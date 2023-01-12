using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPiece : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(collision.tag=="Player")
        {
            Debug.Log(gameObject.tag);
            if(transform.parent.tag == "PieceGnome")
            {
                Inventaire.instance.AjouterPieceGnome(1);
                Destroy(transform.parent.gameObject);
            }
            
        }
    }
}
