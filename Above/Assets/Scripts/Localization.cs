using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Localization : MonoBehaviour
{
   public void Ua()
    {
        string language = "Ua";
        PlayerPrefs.SetString("Language", language);
    }
    public void Eng()
    {
        string language = "Eng";
        PlayerPrefs.SetString("Language", language);
    }
}
