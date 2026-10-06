using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [Header("Spawning")]
    public GameObject coinPrefab;
    public float spawnRate = 2f;
    public Transform[] spawnPoints;

    private float nextSpawnTime = 0f;

    private void Update()
    {
        // Spawn a coin when it is time
        if (Time.time >= nextSpawnTime)
        {
            SpawnCoin();

            // Set the time for the next coin
            nextSpawnTime = Time.time + spawnRate;
        }
        if (GameManager.Instance.score > 400 && GameManager.Instance.score < 900)
            spawnRate = 1.5f;
        if (GameManager.Instance.score > 900 && GameManager.Instance.score < 1400)
            spawnRate = 1.0f;
        if (GameManager.Instance.score > 1400 && GameManager.Instance.score < 2000)
            spawnRate = 0.5f;
    }

    private void SpawnCoin()
    {
        // Check that a coin prefab and spawn points are assigned
        if (coinPrefab && spawnPoints.Length > 0)
        {
            // Choose a random spawn point
            int randomIndex = Random.Range(0, spawnPoints.Length);

            // Create the coin at the chosen spawn point
            Instantiate(coinPrefab, spawnPoints[randomIndex].position, Quaternion.identity);
        }
    }
}