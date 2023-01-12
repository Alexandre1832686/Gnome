using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPiece : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(collision.tag=="Player")
        {
            if(gameObject.tag=="PieceGnome")
            {
                Inventaire.instance.AjouterPieceGnome(1);
            }
            else if (gameObject.tag == "PieceArgent")

            {
                Inventaire.instance.AjouterPieceArgent(1);

            }
            Destroy(transform.parent.gameObject);
        }
    }
}
