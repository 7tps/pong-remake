using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenController : MonoBehaviour
{
    public string mainScene;
    
    public void PlayGame()
    {
        Debug.Log("Starting game...");
        SceneManager.LoadScene(mainScene);
    }

    public void QuitGame()
    {
        // Quit the application
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    
}
