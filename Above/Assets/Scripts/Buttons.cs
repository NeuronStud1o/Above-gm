using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject PlayTransition;

    private void Start()
    {
        PlayTransition.SetActive(false);
    }

    IEnumerator WaitForSecondsExample1()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator WaitForSecondsExample2()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void PlayGame()
    {
        PlayTransition.SetActive(true);
        StartCoroutine(WaitForSecondsExample1());
    }

    public void RetryGame()
    {
        PlayTransition.SetActive(true);
        StartCoroutine(WaitForSecondsExample2());
    }

    public void MainGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
