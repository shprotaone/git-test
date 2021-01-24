using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IntegerVariable", menuName = "Variable/IntegerVariable", order =50)]
public class Variables : ScriptableObject
{
    public delegate void OnVariableChangeEvent(int value);
       
    private event OnVariableChangeEvent listeners;

    public event OnVariableChangeEvent Listeners

    {
        add
        {
            listeners -= value;
            listeners += value;
        }
        remove 
        {            
            listeners -= value;
        }
    }

    private int _value;

    public void SetValue(int value)
    {
        _value = value;
        Raise();        
    }

    public void ApplyChange(int value)
    {
        _value += value;
        Raise();
    }

    private void Raise()
    {
        listeners?.Invoke(_value);
    }
}
