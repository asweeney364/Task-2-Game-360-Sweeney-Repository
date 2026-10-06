using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int value = 1;
    public float lifetime = 5f;

    private void Update()
    {
        
        // counts down so the coin disappears off screen
        lifetime -= Time.deltaTime;

        if (lifetime <= 0f)
        {
            // makes you lose a life and removes the coin
            GameManager.Instance.LoseLife();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // add points and removes the coin
            GameManager.Instance.CoinPickedUp(value);
            Destroy(gameObject);
        }
    }
}