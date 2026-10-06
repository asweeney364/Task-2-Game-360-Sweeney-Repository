using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int value = 1;
    public float lifetime = 5f;

    private void Update()
    {
        
        // Count down until the coin expires
        lifetime -= Time.deltaTime;

        if (lifetime <= 0f)
        {
            // Lose a life and remove the coin
            GameManager.Instance.LoseLife();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Add points and remove the coin
            GameManager.Instance.CoinPickedUp(value);
            Destroy(gameObject);
        }
    }
}