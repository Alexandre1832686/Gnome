using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PieceGnome : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void onTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene("GnomeTourn");
        }
    }
}