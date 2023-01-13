using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    [SerializeField] GameObject menuPrincipale;
    [SerializeField] GameObject optionMenu;
    [SerializeField] GameObject selectLevel;


    private void Start()
    {
        menuPrincipale.SetActive(true);
        optionMenu.SetActive(false);
        selectLevel.SetActive(false);
    }
    /// <summary>
    /// Desactive l'objet donner et affiche celui donner
    /// </summary>
    /// <param name="MenuAfficher"></param>
    /// <param name="MenuPrecedent"></param>
    
    //Envoie l'utilisateur a la prochaine scène selon l'ordre 
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToNiveau(int niveau)
    {//pas oublie que level5 is actually level 4
        SceneManager.LoadScene("map/Level"+niveau);
    }
    /// <summary>
    /// Permet de retourner au menuPrincipale principale
    /// </summary>
    public void BackToPrevious()
    {
        if (optionMenu.activeSelf)
        {
            FindObjectOfType<audiomanager>().Play("onclick");
            optionMenu.SetActive(false);
            menuPrincipale.SetActive(true);
        }
        else
        {
            FindObjectOfType<audiomanager>().Play("onclick");
            selectLevel.SetActive(false);
            menuPrincipale.SetActive(true);
        }
        
    }
    public void GoToOption()
    {
        FindObjectOfType<audiomanager>().Play("onclick");
        menuPrincipale.SetActive(false);
        optionMenu.SetActive(true);
    }
    public void GoToLevelSel()
    {
        FindObjectOfType<audiomanager>().Play("onclick");
        menuPrincipale.SetActive(false);
        selectLevel.SetActive(true);
    }
    public void QuitGame()
    {
        FindObjectOfType<audiomanager>().Play("onclick");
        Application.Quit();
    }
}
