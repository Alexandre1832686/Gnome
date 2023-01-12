using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class autoscroll : MonoBehaviour
{
    float speed = 1;
    float textPostBegin = -460.0f;
    float boundaryTextEnd = 4600.0f;

    RectTransform myGorectTransform;
    // Start is called before the first frame update
    void Start()
    {
        myGorectTransform = gameObject.GetComponent<RectTransform>();
        StartCoroutine(AutoScrollText());
    }

    IEnumerator AutoScrollText()
    {
        while(myGorectTransform.localPosition.y<boundaryTextEnd) 
        {
            myGorectTransform.Translate(Vector3.up* speed*Time.deltaTime);
            yield return null;
        }
    }
}
