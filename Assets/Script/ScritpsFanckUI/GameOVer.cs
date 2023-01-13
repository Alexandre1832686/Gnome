using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOVer : MonoBehaviour
{
   public void BackToMainMenu()
    {
        SceneManager.LoadScene("Scenes/Frankou");
    }
}
