using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VieBoss : MonoBehaviour
{
    [SerializeField] GameObject Canvas;
    GameObject boss;
    // Start is called before the first frame update
    void Start()
    {
        boss=GameObject.Find("Doight");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player")
        {

            boss.GetComponent<BossFinal>().StartFight();
            Canvas.SetActive(true);
            Destroy(gameObject);
        }
    }
}
