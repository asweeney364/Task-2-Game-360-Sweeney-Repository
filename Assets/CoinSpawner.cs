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
        // spawns a coins in
        if (Time.time >= nextSpawnTime)
        {
            SpawnCoin();

            // sets the time for the next coin
            nextSpawnTime = Time.time + spawnRate;
        }
            // makes the coins spawn in faster as the points go up
        if (GameManager.Instance.score > 400 && GameManager.Instance.score < 900)
            spawnRate = 1.5f;
        if (GameManager.Instance.score > 900 && GameManager.Instance.score < 1400)
            spawnRate = 1.0f;
        if (GameManager.Instance.score > 1400 && GameManager.Instance.score < 2000)
            spawnRate = 0.5f;
    }

    private void SpawnCoin()
    {
        
            // Choose a random spawn point
     int randomIndex = Random.Range(0, spawnPoints.Length);

            // Create the coin at the chosen spawn point
     Instantiate(coinPrefab, spawnPoints[randomIndex].position, Quaternion.identity);
        
    }
}