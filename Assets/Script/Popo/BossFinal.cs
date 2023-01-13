using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFinal : Enemie
{
    [SerializeField] List<Transform> positionsDattack;
    [SerializeField] GameObject shadowPrefab;
    GameObject Doight;
    Vector3 DoightPositionRepos;
    bool doightCanMove;
    Transform target;
    GameObject Player;
    [SerializeField] GameObject PieceGnomes;


    private void Awake()
    {
        Player = GameObject.Find("Perso");
        speed = 0.8f;
        hpMax = 35;
        doightCanMove = false;
        Doight = gameObject;
        DoightPositionRepos = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        canBeAttacked = true;
        hpActu = hpMax;
        RefreshUI();
    }

    // Update is called once per frame
    void Update()
    {
        if(doightCanMove)
        {
            Doight.transform.position = Vector2.MoveTowards(transform.position,target.position,30*Time.deltaTime);
        }
        else
        {
            Doight.transform.position = Vector2.MoveTowards(transform.position, DoightPositionRepos, 30 * Time.deltaTime);
        }
    }

    public void StartFight()
    {
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        target = positionsDattack[Random.Range(0, positionsDattack.Count-1)];
        GameObject shadow = Instantiate(shadowPrefab, target.position, Quaternion.identity);
        yield return new WaitForSeconds(1);

        Destroy(shadow);
        doightCanMove = true;
        yield return new WaitForSecondsRealtime(0.2f);
        if (Vector2.Distance(transform.position, Player.transform.position) <= 2)
        {
            Player.GetComponent<Gnome>().retirerVie();
        }
        yield return new WaitForSeconds(3);
        doightCanMove = false;
        StartCoroutine(Attack());
    }

    public override void TakeDammage(float dammage)
    {
        base.TakeDammage(dammage);
    }

    protected override void Die()
    {
        int i = Random.Range(0, 100);
        Instantiate(PieceGnomes, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
