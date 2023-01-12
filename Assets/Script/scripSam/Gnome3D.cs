using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gnome3D : MonoBehaviour
{
    [SerializeField] private int pieceTotal=28;
    [SerializeField] private int pieceAcumuler;
    GameObject currentModel;
    [SerializeField] Material Invisible;
    
    // Start is called before the first frame update
    void Start()
    {
        currentModel = gameObject;
        pieceAcumuler = 20;
        for(int i=0; i<pieceTotal-pieceAcumuler; i++)
        {
            currentModel.transform.GetChild(i).GetComponent<MeshRenderer>().material= Invisible;
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
   
    
}
