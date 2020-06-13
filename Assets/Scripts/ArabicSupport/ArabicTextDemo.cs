using UnityEngine;
using TMPro;
using System.Collections;
using ArabicSupport;

[ExecuteAlways]
public class ArabicTextDemo : MonoBehaviour
{
    public string text;
    public bool tashkeel = true;
    public bool hinduNumbers = true;

    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = ArabicFixer.Fix(text, tashkeel, hinduNumbers);
    }
}
