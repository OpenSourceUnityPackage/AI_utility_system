using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Range
{
    [SerializeField] private float _value;
    public float min;
    public float max;

    public Range(float value, float _min, float _max)
    {
        _value = value;
        min = _min;
        max = _max;
    }

    public float Value
    {
        get
        {
            return _value;
        }
        set
        {                
            _value = Mathf.Clamp(value, min, max);
        }
    }

    public float Ratio()
    {
        return (_value - min) / (max - min);
    }
}