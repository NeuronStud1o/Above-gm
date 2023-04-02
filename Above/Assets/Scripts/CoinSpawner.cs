using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject FlyCoin;
    public GameObject SuperCoin;

    private void Start()
    {
        Vector2 SpawnPos = new Vector2();
        Vector2 SpawnPos2 = new Vector2();

        for (int i = 0; i < 5; i++)
        {
            SpawnPos.x = Random.Range(-1, 1);
            SpawnPos.y += Random.Range(5f, 30f);

            Instantiate(FlyCoin, SpawnPos, Quaternion.identity);
        }

        for (int i = 0; i < 2; i++)
        {
            SpawnPos2.x = Random.Range(-1, 1);
            SpawnPos2.y += Random.Range(10f, 100f);

            Instantiate(SuperCoin, SpawnPos2, Quaternion.identity);
        }
    }
}

