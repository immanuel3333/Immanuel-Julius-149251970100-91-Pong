using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created By Immanuel Julius-149251970100-91");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void OpenCredit()
    {
        SceneManager.LoadScene("Credit");
    }
}
