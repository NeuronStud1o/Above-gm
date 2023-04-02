using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsManager : MonoBehaviour
{
    public int coinsF;
    public Text moneyText;
    public GameObject CoinsF;

    public int coinsS;
    public Text moneyText2;
    public GameObject CoinsS;

    void Start()
    {
        if (PlayerPrefs.HasKey("coinsF"))
        {
            coinsF = PlayerPrefs.GetInt("coinsF");
        }

        if (PlayerPrefs.HasKey("coinsS"))
        {
            coinsS = PlayerPrefs.GetInt("coinsS");
        }
    }
    void Update()
    {
        moneyText.text = "" + coinsF;
        PlayerPrefs.SetInt("coinsF", coinsF);

        moneyText2.text = "" + coinsS;
        PlayerPrefs.SetInt("coinsS", coinsS);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "FlyCoin")
        {
            coinsF++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "SuperCoin")
        {
            coinsS++;
            Destroy(collision.gameObject);
        }
    }
}




