using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioControl : MonoBehaviour
{
    public Sprite audioOn;
    public Sprite audioOff;
    public GameObject buttonAudio;

    public Slider slider;

    public AudioClip clip;
    public AudioSource AllAudio;

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("Slider");
        AudioListener.volume = PlayerPrefs.GetFloat("OnOfAudio");

        if (AudioListener.volume == 0)
        {
            buttonAudio.GetComponent<Image>().sprite = audioOff;
        }
        else
        {
            buttonAudio.GetComponent<Image>().sprite = audioOn;
        }
    }

    void Update()
    {
        AllAudio.volume = slider.value;
        PlayerPrefs.SetFloat("Slider", slider.value);
    }

    public void OnOffAudio()
    {
        if (AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
            PlayerPrefs.SetFloat("OnOfAudio", AudioListener.volume);
            buttonAudio.GetComponent<Image>().sprite = audioOff;
        }
        else
        {
            AudioListener.volume = 1;
            PlayerPrefs.SetFloat("OnOfAudio", AudioListener.volume);
            buttonAudio.GetComponent<Image>().sprite = audioOn;
        }
    }
    public void PlaySound()
    {
        AllAudio.PlayOneShot(clip);
    }
}
