using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawned Prefabs")]
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] GameObject coinPrefab;

    [Header("Spawner Variables")]
    [SerializeField] float spawnRate;
    [Range(0, 100)]
    [SerializeField] int spawnCoinChance;
    [SerializeField] float spawnRange;
    [SerializeField] float obstacleTorque;

    private GameObject playerCharacter;
    private ScoreKeeper scoreKeeper;

    // Start is called before the first frame update
    void Start()
    {
        playerCharacter = GameObject.Find("Player Character");
        scoreKeeper = playerCharacter.GetComponent<ScoreKeeper>();
        StartCoroutine(spawnItem());
    }

    IEnumerator spawnItem()
    {
        float spawnRoll;
        float spawnPosition;
        while (playerCharacter.activeInHierarchy)
        {
            spawnPosition = Random.Range(-spawnRange, spawnRange);
            spawnRoll = Random.Range(0, 100);
            if (spawnRoll <= spawnCoinChance)
            {
                spawnCoin(spawnPosition);
            }
            else
            {
                spawnObstacle(spawnPosition);
            }
            yield return new WaitForSeconds(spawnRate);
        }
    }

    private void spawnObstacle(float spawnPosition)
    {
        float torqueVariance = Random.Range(0f, 1f);
        
        Rigidbody2D obstacleRB = Instantiate(obstaclePrefab, new Vector3(spawnPosition, transform.position.y, 0), Quaternion.identity).GetComponent<Rigidbody2D>();
        obstacleRB.AddTorque(obstacleTorque * (1 - torqueVariance), ForceMode2D.Impulse);
    }

    private void spawnCoin(float spawnPosition)
    {
        spawnPosition = Random.Range(-spawnRange, spawnRange);
        Coin coin = Instantiate(coinPrefab, new Vector3(spawnPosition, transform.position.y, 0), coinPrefab.transform.rotation).GetComponent<Coin>();
        coin.setScoreKeeper(scoreKeeper);
    }
}
