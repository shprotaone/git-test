using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    public GameObject coin;
    public float startDelay;
    private float[] spawnRangeX = new float[] { 1.8f, 0, -1.8f}; 
    private float floatFromNumbers;
    private float spawnPosZ = 10;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {        
        int spawnInterval = Random.Range(1,6);
        InvokeRepeating("SpawnRandom",startDelay,spawnInterval);         
    }

    void Update()
    {
        
    }

    void SpawnRandom()
    {
        int randomIndex = Random.Range(0, 3);
        floatFromNumbers = spawnRangeX[randomIndex];
        Vector3 spawnPos = new Vector3(floatFromNumbers, 0.5f, spawnPosZ);
        GameObject spawnCoin = Instantiate(coin, spawnPos, coin.transform.rotation);
        
        Debug.Log("Index " + randomIndex);
        Debug.Log("From " + floatFromNumbers);

    }
}
