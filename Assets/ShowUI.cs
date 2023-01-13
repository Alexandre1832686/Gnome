using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{
    public GameObject canvas;
    public Text textPopUp;
    public string Message;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.tag == "Player")
        {
            canvas.SetActive(true);
            textPopUp.text = Message;
            gameObject.GetComponent<Collider2D>().enabled = false;
            StartCoroutine(TimeLapse());
        }
        
    }

    IEnumerator TimeLapse()
    {
        yield return new WaitForSeconds(5);
        textPopUp.text = "";
        canvas.SetActive(false);

    }
}
