using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    [SerializeField] private Variables coinCounter = default;
    private StorageCoin storageCoin;
    public ParticleSystem particle;

    public bool destroy;
    private string material;

    private void Start()
    {
        material = GetComponent<Renderer>().name;
        storageCoin = GameObject.Find("Main Camera").GetComponent<StorageCoin>();

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(material == "SpeedUp(Clone)")
            {
                storageCoin.showBonus("Speed");
                
                destroy = true;
                Destroy(this.gameObject);
            }
            if(material == "immortal(Clone)")
            {
                storageCoin.showBonus("Immortal");
                particle.Play();
                
                destroy = true;
                Destroy(this.gameObject);
            }
            if (material == "Coin(Clone)")
            {
                coinCounter.ApplyChange(1);
                destroy = true;
                Destroy(this.gameObject);
            }                    
        }               
    }

    

}
