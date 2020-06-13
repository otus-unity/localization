using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SystemLanguageDemo : MonoBehaviour
{
    void Awake()
    {
        var text = GetComponent<TextMeshProUGUI>();
        switch (Application.systemLanguage) {
            case SystemLanguage.English:
                text.text = "Hello, world!";
                break;
            case SystemLanguage.Russian:
                text.text = "Здравствуй, мир!";
                break;
        }
    }
}
