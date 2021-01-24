using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawner : MonoBehaviour
{
    public GameObject[] bonusPrefab;

    [SerializeField] private GameObject[] currentObj;
    [SerializeField] private bool destroy;

    void Start()
    {
        destroy = GameObject.FindGameObjectWithTag("Item");
    }
    void Update()
    {
        currentObj = GameObject.FindGameObjectsWithTag("Item");
        if (currentObj.Length < 4)
        {
            Spawn();
        }       
    }

    public Vector3 NextPosition()
    {
        Vector3[] position = new[] {    new Vector3(-3, 0), 
                                        new Vector3(-3, 2), 
                                        new Vector3(-3, -2), 
                                        new Vector3(-3, 4), 
                                        new Vector3(-3, -4),
                                        new Vector3(0,4),
                                        new Vector3(0,-4),
                                        new Vector3(3, 0),
                                        new Vector3(3, 2),
                                        new Vector3(3, -2),
                                        new Vector3(3, 4),
                                        new Vector3(3, -4)};

        int rndmIndex = Random.Range(0, position.Length);
        return position[rndmIndex];
    }


    public void Spawn()
    {
        int randomIndex = Random.Range(0, bonusPrefab.Length);
        GameObject instantiate = Instantiate(bonusPrefab[randomIndex], NextPosition(), Quaternion.identity);
        AddDebug("Hello");
    }

    public void AddDebug(string message)
    {
        Debug.Log(message);
    }

    

}
