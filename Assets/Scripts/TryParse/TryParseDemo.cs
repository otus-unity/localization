using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class TryParseDemo : MonoBehaviour
{
    void Awake()
    {
        float value = float.Parse("1.23");
        string str = value.ToString();
        Debug.Log(str);
        Debug.Log($"{value}");
    }
}
