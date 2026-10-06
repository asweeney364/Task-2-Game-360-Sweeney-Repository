using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Singleton instance of the GameManager
    public static GameManager Instance { get; private set; }

    [Header("Game Data")]
    public int score = 0;
    public int lives = 3;

    // Events that other scripts can subscribe to
    public event Action<int> ScoreChanged;
    public event Action<int> LivesChanged;
    // Drag the Game Over panel here in the Inspector
    public GameObject gameOverPanel;

    private void Awake()
    {
        // Keep only one GameManager
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            // Destroy an extra copy of the manager
            Destroy(gameObject);
        }
    }

    public void CoinPickedUp(int points)
    {
        // Add points when a coin is collected
        score += points;

        // Show the coin's point value and total score in the Console
        Debug.Log(" |Score: " + score);

        // Notify listeners of the new score
        ScoreChanged?.Invoke(score);
    }

    public void LoseLife()
    {
        // Prevent lives from going below zero
        if (lives <= 0) return;

        lives--;

        // Notify listeners of the remaining lives
        LivesChanged?.Invoke(lives);

        if (lives == 0)
        {
            // Show Game Over and pause the game
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void RestartGame()
    {
        // Unpause before restarting
        Time.timeScale = 1f;

        // Reload the scene to reset score, lives, player, and coins
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}