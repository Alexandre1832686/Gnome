using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VieBoss : MonoBehaviour
{
    [SerializeField] GameObject premiereImage;
    [SerializeField] GameObject image;
    [SerializeField]Enemie boss;
    // Start is called before the first frame update
    void Start()
    {
       premiereImage.SetActive(false);
       
        
    }

    // Update is called once per frame
    void Update()
    {
        afficherVie();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("allo");
            premiereImage.SetActive(true);
            if (boss.name == "Doight")
            {
                boss.GetComponent<BossFinal>().StartFight();
            }
        }
        
    }

    private void afficherVie()
    {
        float width = boss.hpActu * 1000 / boss.hpMax;

        var theBarRectTransform = image.transform as RectTransform;
        theBarRectTransform.sizeDelta = new Vector2(width, theBarRectTransform.sizeDelta.y);
    }
}
