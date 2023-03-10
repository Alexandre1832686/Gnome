using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class autoscroll : MonoBehaviour
{
    float speed = 1;
    float boundaryTextEnd = 4800.0f;

    RectTransform myGorectTransform;
    // Start is called before the first frame update
    void Start()
    {
        myGorectTransform = gameObject.GetComponent<RectTransform>();
        StartCoroutine(AutoScrollText());
    }
    void Update()
    {
        if (myGorectTransform.localPosition.y >= boundaryTextEnd)
        {
            SceneManager.LoadScene("Level1");
        }
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
