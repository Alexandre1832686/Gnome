using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{
    public GameObject uiGObject;
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            GameObject a = Instantiate(uiGObject);
            a.transform.GetChild(0).GetComponent<Text>().text = text;
            gameObject.GetComponent<Collider2D>().enabled = false;
            StartCoroutine(TimeLapse());
        }
    }
    IEnumerator TimeLapse()
    {
        yield return new WaitForSeconds(5);
        Destroy(uiGObject);
        Destroy(gameObject);
    }
}
