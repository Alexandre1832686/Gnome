using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Scenes/Frankou");
    }

    private void Start()
    {
        GameObject optionMenu = GameObject.Find("OptionsMenu");
        GameObject menuPause = GameObject.Find("");
        optionMenu.SetActive(false);

    }
    public void GoToOption()
    {
        /*menuPrincipale.SetActive(false);
        optionMenu.SetActive(true);*/
    }
}
