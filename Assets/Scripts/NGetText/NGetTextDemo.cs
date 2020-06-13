using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Example;
using NGettext;

public class NGetTextDemo : MonoBehaviour
{
    void Awake()
    {
        var text = GetComponent<TextMeshProUGUI>();
        text.text = T._("Hello, world!");
    }
}
