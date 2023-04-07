using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{

    public string language;
    Text text;

    public string textUa;
    public string textEng;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        language = PlayerPrefs.GetString("Language");

        if(language == "" || language == "Eng")
        {
            text.text = textEng;
        }
        else if (language == "Ua")
        {
            text.text = textUa;
        }
    }
}
