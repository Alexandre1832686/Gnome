using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gnome3D : MonoBehaviour
{
    [SerializeField] private int pieceTotal=4;
    [SerializeField] private int pieceAcumuler;
    GameObject currentModel;
    [SerializeField] Material Invisible;
    
    // Start is called before the first frame update
    void Start()
    {
        currentModel = gameObject;
        pieceAcumuler = Inventaire.pieceGnome;
        for(int i=0; i<pieceTotal-pieceAcumuler; i++)
        {
            for(int j=0;j<currentModel.transform.GetChild(i).childCount;j++)
            {
                currentModel.transform.GetChild(i).GetChild(j).GetComponent<MeshRenderer>().material= Invisible;
                
            }
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void ChangementLevel()
    {
        if(pieceAcumuler ==1)
        {
            SceneManager.LoadScene("map/Level2");
        }
        if(pieceAcumuler ==2)
        {
            SceneManager.LoadScene("map/Level3");
        }
        if(pieceAcumuler ==3)
        {
            SceneManager.LoadScene("map/Level5");
        }

    }
   
    
}
