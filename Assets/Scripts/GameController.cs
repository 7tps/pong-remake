using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("UI References")]
    public GameObject countdownPanel;  
    public TextMeshProUGUI countdownText;         
    
    [Header("Game References")]
    public BallController ball;            
    public PlayerController player;        
    public OpponentController opponent;
    public TextMeshProUGUI playerText;
    public TextMeshProUGUI opponentText;
    public int playerScore;
    public int opponentScore;
    public int winAmount;
    
    [Header("Countdown Settings")]
    public float countdownDuration = 1f;

    [Header("Scene Settings")] 
    public string winScene;
    public string loseScene;
    
    void Start()
    {
        StartCountdown();
    }
    
    public void StartCountdown()
    {
        // Make sure the countdown panel is visible
        countdownPanel.SetActive(true);
        
        // Disable game objects during countdown
        DisableGameplay();
        
        // Start the countdown coroutine
        StartCoroutine(CountdownSequence());
    }

    public void IncreasePlayerScore()
    {
        playerScore++;
        playerText.text = playerScore.ToString();
        if (playerScore == winAmount)
        {
            SceneManager.LoadScene(winScene);
        }
    }

    public void IncreaseOpponentScore()
    {
        opponentScore++;   
        opponentText.text = opponentScore.ToString();
        if (opponentScore == winAmount)
        {
            SceneManager.LoadScene(loseScene);
        }
    }
    
    IEnumerator CountdownSequence()
    {
        // Show "3"
        countdownText.text = "3";
        yield return new WaitForSeconds(countdownDuration);
        
        // Show "2"
        countdownText.text = "2";
        yield return new WaitForSeconds(countdownDuration);
        
        // Show "1"
        countdownText.text = "1";
        yield return new WaitForSeconds(countdownDuration);
        
        // Show "START"
        countdownText.text = "START";
        yield return new WaitForSeconds(countdownDuration);
        
        // Hide countdown and start the game
        countdownPanel.SetActive(false);
        EnableGameplay();
        ball.StartGame();
    }
    
    void DisableGameplay()
    {
        // Stop the ball if it's moving
        if (ball != null)
        {
            Rigidbody2D ballRb = ball.rb;
            if (ballRb != null)
            {
                ballRb.velocity = Vector2.zero;
            }
            ball.gameObject.SetActive(false);
        }
        
        player.gameObject.SetActive(false);
        opponent.gameObject.SetActive(false); 
    }
    
    void EnableGameplay()
    {
        if (ball != null)
        {
            ball.gameObject.SetActive(true);
        }
        
        player.gameObject.SetActive(true);
        opponent.gameObject.SetActive(true); 
    }
    
    // Optional: Call this method to restart the countdown (useful for restarting games)
    public void RestartCountdown()
    {
        StopAllCoroutines();
        StartCountdown();
    }
}