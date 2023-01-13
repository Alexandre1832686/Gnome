using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    GameObject optionMenu;
    GameObject menuPause;
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Scenes/Frankou");
    }

    private void Start()
    {
         optionMenu = GameObject.Find("OptionsMenu");
         menuPause = GameObject.Find("MenuPause");
        
        optionMenu.SetActive(false);
        menuPause.SetActive(true);
    }
    public void GoToOption()
    {
       menuPause.SetActive(false);
        optionMenu.SetActive(true);
    }
    public void GoBackFromOption()
    {
        optionMenu.SetActive(false);
        menuPause.SetActive(true);
    }
}
