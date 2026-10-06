using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameManager gameManager;

    private void OnEnable()
    {
        // Subscribe to the score event
        gameManager.ScoreChanged += UpdateScore;

        // Display the starting score
        UpdateScore(gameManager.score);
    }

    private void OnDisable()
    {
        // Unsubscribe from the score event
        gameManager.ScoreChanged -= UpdateScore;
    }

    private void UpdateScore(int score)
    {
        // Update the text when the score changes
        scoreText.text = "Score: " + score;
    }
}