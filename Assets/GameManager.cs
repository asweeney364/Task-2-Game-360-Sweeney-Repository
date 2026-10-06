using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // singleton for GameManager
    public static GameManager Instance { get; private set; }

    [Header("Game Data")]
    public int score = 0;
    public int lives = 3;

    // Events that other scripts can subscribe to
    public event Action<int> ScoreChanged;
    public event Action<int> LivesChanged;
    
    public GameObject gameOverPanel;

    private void Awake()
    {
        // keeps only one GameManager
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            // destroys an extra copy of the manager
            Destroy(gameObject);
        }
    }

    public void CoinPickedUp(int points)
    {
        // adds points when a coin is collected
        score += points;

        // shows the score in the console
        Debug.Log("Score: " + score);

        // notifys listeners of the new score
        ScoreChanged?.Invoke(score);
    }

    public void LoseLife()
    {
        // prevents lives from going below zero
        if (lives <= 0) return;

        // takes away one life
        lives--;

        // sends signal to listeners of the lives left
        LivesChanged?.Invoke(lives);

        if (lives == 0)
        {
            // shows game over and pauses the game
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void RestartGame()
    {
        // unpauses the game
        Time.timeScale = 1f;

        // reloads the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}