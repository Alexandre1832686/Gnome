using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PieceGnome : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Perso");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Inventaire.AjouterPieceGnome();
            Player.GetComponent<Gnome>().AjouterVie();
            SceneManager.LoadScene("Scenes/GnomeTourn");
        }
    }
}
