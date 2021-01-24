using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAreaSpawner : MonoBehaviour
{

    public GameObject itemToSpread; // объект для спавна
    public int numItemToSpawn = 10; //количетсво заспавненых

    public float itemXSpread = 10; //X
    public float itemYSpread = 0;  //Y
    public float itemZSpread = 10; //Z 

    private void Start()
    {
        for (int i = 0; i < numItemToSpawn; i++)
        {
            
        }
    }
    void SpreadItems()
    {
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread)) + transform.position;
        Instantiate(itemToSpread, transform.localPosition = randPosition, Quaternion.identity); 
    }
}
