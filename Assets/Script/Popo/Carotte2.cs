using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carotte2 : Enemie
{
    [SerializeField] GameObject PieceGnomes;
    public bool untargetable;
    [SerializeField] GameObject troue;
    GameObject Player;

    private void Awake()
    {
        speed = 1.2f;
        hpMax = 25;
    }

    // Start is called before the first frame update
    void Start()
    {
        canBeAttacked = true;
        hpActu = hpMax;
        RefreshUI();
        Player = GameObject.Find("Perso");
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(2);
        untargetable = true;
        GameObject a=Instantiate(troue, Player.transform.position, Quaternion.identity);
        a.transform.SetParent(transform);
        yield return new WaitForSeconds(1);
        transform.position = a.transform.position;
        if (Vector2.Distance(Player.transform.position,a.transform.position)<=1.05f)
        {
            Player.GetComponent<Gnome>().retirerVie();
        }
        
        Destroy(a);
        StartCoroutine(Attack());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(Attack());
        }
    }

    protected override void Die()
    {
        
        Instantiate(PieceGnomes, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
