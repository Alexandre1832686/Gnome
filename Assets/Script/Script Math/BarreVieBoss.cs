using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarreVieBoss : MonoBehaviour
{
    [SerializeField]Enemie boss;
    [SerializeField]GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (boss != null)
        {
            
        }
    }

    private void afficherVie()
    {
        float width = boss.hpActu * 1000/boss.hpMax;
        
        var theBarRectTransform = image.transform as RectTransform;
        theBarRectTransform.sizeDelta = new Vector2(width, theBarRectTransform.sizeDelta.y);
    }
}
