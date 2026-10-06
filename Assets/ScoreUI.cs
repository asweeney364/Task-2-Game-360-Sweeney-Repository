using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameManager gameManager;

    private void OnEnable()
    {
        // subscribes to the score event
        gameManager.ScoreChanged += UpdateScore;

        // shows the starting score
        UpdateScore(gameManager.score);
    }

    private void OnDisable()
    {
        // unsubscribes from the score event
        gameManager.ScoreChanged -= UpdateScore;
    }

    private void UpdateScore(int score)
    {
        // updates the text when the score changes
        scoreText.text = "Score: " + score;
    }
}