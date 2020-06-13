using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Example;
using NGettext;

public class NGetTextDemo : MonoBehaviour
{
    public int lifeCount = 1;

    void Awake()
    {
        var text = GetComponent<TextMeshProUGUI>();
        //text.text = T._("Hello, world!");
        text.text = T._n("You have {0} life.", "You have {0} lifes.", lifeCount, lifeCount);
    }
}
