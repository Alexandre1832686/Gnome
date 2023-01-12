using SuperTiled2Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gnome : MonoBehaviour
{
    [SerializeField] public GameObject imagecoeur;
    Rigidbody2D rb;
    float inputHorizontal;
    float inputVertical;
    GameObject fin;
    static int vie = 3,vieMax = 3;
    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
        fin = GameObject.Find("Over");
        fin.SetActive(false);
        AfficherVie();
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.E)) {
            SceneManager.LoadScene("Level2");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "HealKit")
        {
            if (vie < vieMax)
                vie++;

            AfficherVie();
            Destroy(collision.gameObject);
            
        }
        
    }

    public void retirerVie()
    {
        vie--;
        AfficherVie();
        if(vie <= 0)
        {
            Time.timeScale= 0f;
            fin.gameObject.SetActive(true);
            
        }
    }

    private void AfficherVie()
    {
        for (int y = 0; y < vieMax; y++)
        {
            imagecoeur.transform.GetChild(y).gameObject.SetActive(true);
            imagecoeur.transform.GetChild(y).gameObject.GetComponent<Image>().color = Color.black;
        }

        for (int y = 0; y < vie; y++)
        {
            imagecoeur.transform.GetChild(y).gameObject.GetComponent<Image>().color = Color.red;
        }

        for (int y = 0; y < vie; y++)
        {
            Debug.Log(vie);
            
            imagecoeur.transform.GetChild(y).gameObject.SetActive(true);
        }
    }

    
    public void AjouterVie()
    {
        vieMax ++;
        Debug.Log(vieMax);   
        imagecoeur.transform.GetChild(vie - 1).gameObject.SetActive(true);
        vie = vieMax;
    }

 

    static public void RefreshUI()
    {
       
    }
}
