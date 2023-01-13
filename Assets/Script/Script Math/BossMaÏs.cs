using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class BossMaÏs : Enemie
{
    [SerializeField] GameObject PieceGnomes;
    private GameObject player;

    private void Awake()
    {
        hpMax = 30;
    }
    // Start is called before the first frame update
    void Start()
    {
        canBeAttacked = true;
        hpActu = hpMax;
        RefreshUI();
        player = GameObject.Find("Perso");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void Die()
    {
        Destroy(gameObject);
        Instantiate(PieceGnomes, transform.position, Quaternion.identity);
        
    }
}
