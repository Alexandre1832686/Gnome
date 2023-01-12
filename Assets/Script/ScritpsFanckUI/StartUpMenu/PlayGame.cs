using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    [SerializeField] GameObject menuPrincipale;
    [SerializeField] GameObject optionMenu;
    [SerializeField] GameObject SelectLevel;


    private void Start()
    {
        menuPrincipale.SetActive(true);
        optionMenu.SetActive(false);
        SelectLevel.SetActive(false);
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
    /// <summary>
    /// Permet de retourner au menuPrincipale principale
    /// </summary>
    public void BackToPrevious()
    {
        if(optionMenu.activeSelf)
        {
            optionMenu.SetActive(false);
            menuPrincipale.SetActive(true);
        }
        else
        {
            SelectLevel.SetActive(false);
            menuPrincipale.SetActive(true);
        }
        
    }
    public void GoToOption()
    {
        menuPrincipale.SetActive(false);
        optionMenu.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
