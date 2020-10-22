using System.Collections;
using System.Collections.Generic;
using System;
using System.Globalization;
using UnityEngine;

public class TryParseDemo : MonoBehaviour
{
    void Awake()
    {
        float value = float.Parse("1.23", CultureInfo.InvariantCulture);
        string str = value.ToString(CultureInfo.InvariantCulture);
        Debug.Log(str);
        Debug.Log(FormattableString.Invariant($"{value}"));
    }
}
