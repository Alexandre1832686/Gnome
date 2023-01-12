using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventaire : MonoBehaviour
{
    [SerializeField]  int pieceM=0;
    [SerializeField]   int pieceGnome=0;
    
    public static Inventaire instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("plus d'un inventaire dans la scène");
            return;
        }
        instance = this;
    }

    public void AjouterPieceArgent(int count)
    {
        pieceM+=count;
    }
    public void AjouterPieceGnome(int count)
    {
        pieceGnome += count;
    }


}
