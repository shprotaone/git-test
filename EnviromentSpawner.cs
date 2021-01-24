using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentSpawner : MonoBehaviour
{
    public GameObject[] enviroment;

    private float rightPosX;
    private float leftPosX;
    private float posZ;
    private int randomEnviroment;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            for(int i = 0; i < 3; i++)
            {
                SpawnRandom();
            }
            
        }
    }

    void SpawnRandom()
    {
        randomEnviroment = Random.Range(0, enviroment.Length);//тип объекта        
        leftPosX = -3.2f;
        rightPosX = 3.2f;

        posZ = Random.Range(-5, 5);

        Vector3 leftSpawn = new Vector3(leftPosX, 0.5f, posZ);
        Vector3 rightSpawn = new Vector3(rightPosX, 0.5f, posZ);
        Instantiate(enviroment[randomEnviroment], leftSpawn, Quaternion.identity);
        Instantiate(enviroment[randomEnviroment], rightSpawn, Quaternion.identity);
    }
}

