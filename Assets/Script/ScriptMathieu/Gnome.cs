using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gnome : MonoBehaviour
{
    Rigidbody2D rb;
    float inputHorizontal;
    float inputVertical;
    int vie = 3;
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
            --vie;
            
            AfficherVie();
        }
        if (collision.tag == "HealKit")
        {
            if (vie == 3)
            {
                vie++;
                AjouterVie();
            }

            if(vie!=3)
            {
                vie++;
            }
            

            AfficherVie();
        }

    }

    private void AfficherVie()
    {
        for (int y = 0; y < coeur.Count-1; y++)
        {
            Debug.Log(coeur.Count);
            coeur[y].GetComponent<Renderer>().material.color = Color.white;
        }

        for (int y = 0; y < vie-1; y++)
        {
            coeur[y].GetComponent<Renderer>().material.color = Color.red;
        }
    }

    private void AjouterVie()
    {
        GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.transform.SetPositionAndRotation(new Vector3(-6.5f, -4.149f, 0), Quaternion.Euler(0f, 0f, 0f));
        coeur.Add(GameObject.Find("Coeur(" + (coeur.Count-1) + ")"));
        Debug.Log(coeur.Count);

    }
}
