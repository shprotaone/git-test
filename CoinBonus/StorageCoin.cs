using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorageCoin : MonoBehaviour
{
    [SerializeField] private Text textField = default;   
    [SerializeField] private Variables coinCounter = default;

    public Text bonus;

    private void Awake()
    {
        coinCounter.Listeners += ChangeTextField;       
    }

    private void ChangeTextField(int value)
    {
        textField.text = value.ToString();
    }

    private void ChangeTextField(string name)
    {
        bonus.text = name;
    }

    private void OnDestroy()
    {
        coinCounter.Listeners -= ChangeTextField;
    }

    public void showBonus(string nameBonus)
    {
        if (nameBonus == "Speed")
        {
            bonus.enabled = true;
            bonus.color = Color.green;
            bonus.text = "You are faster";
            Invoke("disableUI", 5);
        }
        if (nameBonus == "Immortal")
        {
            bonus.enabled = true;
            bonus.color = Color.yellow;
            bonus.text = "You are Immortal";
            Invoke("disableUI", 5);
        }

    }

    private void disableUI()
    {
        bonus.enabled = false;
    }

}
