using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenController : MonoBehaviour
{
    public float delayBeforeLoad = 3f; 
    public string mainScene;
    
    public void PlayGame()
    {
        Debug.Log("Starting game...");
        StartCoroutine(LoadSceneAfterDelay());
    }
    
    IEnumerator LoadSceneAfterDelay()
    {
        // Load the main game scene
        yield return new WaitForSeconds(delayBeforeLoad);
        SceneManager.LoadScene(mainScene);
    }

    public void QuitGame()
    {
        // Quit the application
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    
}
