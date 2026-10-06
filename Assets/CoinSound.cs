using UnityEngine;

public class CoinSound : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource audioSource;

    private void OnEnable()
    {
        // Play sound when the score changes
        gameManager.ScoreChanged += PlaySound;
    }

    private void OnDisable()
    {
        // Remove the listener
        gameManager.ScoreChanged -= PlaySound;
    }

    private void PlaySound(int score)
    {
        audioSource.Play();
    }
}