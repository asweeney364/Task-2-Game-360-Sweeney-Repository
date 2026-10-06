using TMPro;
using UnityEngine;

public class LivesUI : MonoBehaviour
{
    public TMP_Text livesText;
    public GameManager gameManager;

    private void OnEnable()
    {
        // subscribes to the lives event
        gameManager.LivesChanged += UpdateLives;

        // displays the lives at the start
        UpdateLives(gameManager.lives);
    }

    private void OnDisable()
    {
        // unsubscribes from the lives event
        gameManager.LivesChanged -= UpdateLives;
    }

    private void UpdateLives(int lives)
    {
        // updates the text when lives change
        livesText.text = "Lives: " + lives;
    }
}