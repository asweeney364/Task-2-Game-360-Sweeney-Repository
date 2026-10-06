using TMPro;
using UnityEngine;

public class LivesUI : MonoBehaviour
{
    public TMP_Text livesText;
    public GameManager gameManager;

    private void OnEnable()
    {
        // Subscribe to the lives event
        gameManager.LivesChanged += UpdateLives;

        // Display the starting lives
        UpdateLives(gameManager.lives);
    }

    private void OnDisable()
    {
        // Unsubscribe from the lives event
        gameManager.LivesChanged -= UpdateLives;
    }

    private void UpdateLives(int lives)
    {
        // Update the text when lives change
        livesText.text = "Lives: " + lives;
    }
}