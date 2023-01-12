using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Gnome : MonoBehaviour
{
    Rigidbody2D rb;
    float inputHorizontal;
    float inputVertical;
    int vie = 3;
    static int pieces = 0;
    List<GameObject> coeur = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
        for (int x = 0; x < vie; x++)
        {
            coeur.Add(GameObject.Find("Coeur(" + x + ")"));
        }
        AfficherVie();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");

        rb.MovePosition(new Vector2(transform.position.x, transform.position.y) + new Vector2(inputHorizontal, inputVertical) * 10 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemie")
        {
            vie--;

            AfficherVie();
            
        }
        if (collision.tag == "HealKit")
        {
            AjouterVie();
            AfficherVie();
        }
            Destroy(collision.gameObject);
    }

    private void AfficherVie()
    {
        for (int y = 0; y < (coeur.Count); y++)
        {
            Debug.Log(coeur.Count);
            coeur[y].GetComponent<Renderer>().material.color = Color.white;
        }

        for (int y = 0; y < vie; y++)
        {
            Debug.Log(vie);
            coeur[y].GetComponent<Renderer>().material.color = Color.red;
        }
    }

    
    private void AjouterVie()
    {
        vie++;
        GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.transform.SetPositionAndRotation(new Vector3(GameObject.Find("Coeur(" + (coeur.Count - 1) + ")").transform.position.x + 1, -4.19f, 0), Quaternion.Euler(0f, 0f, 0f));
        capsule.transform.localScale = new Vector3(0.6843657f, 0.3031606f,1f);
        capsule.name = "Coeur("+(coeur.Count)+")";
        capsule.GetComponent<Renderer>().material.shader = GameObject.Find("Coeur(0)").GetComponent<Renderer>().material.shader;
        coeur.Add(capsule);

        GameObject barreVie = GameObject.Find("BarreVie");
        barreVie.transform.localScale = new Vector3(barreVie.transform.localScale.x+1f,barreVie.transform.localScale.y,1f);
        barreVie.transform.position = new Vector3(barreVie.transform.position.x + 0.5f, barreVie.transform.position.y, 1f);


    }

    static public void RefreshUI()
    {
        if (Input.GetKeyDown("C"))
        {
            pieces++;
        }
        else if (Input.GetKeyDown("D"))
        {
            pieces--;
        }

        


    }
}
