using System;
using UnityEngine.UI;
using UnityEngine;

public class Reward : MonoBehaviour
{
    public float msToWait = 5000.0f;

    private Text Timer;

    private Button RewardButton;

    private ulong lastOpen;

    public GameObject Done;

    void Start()
    {
        RewardButton = GetComponent<Button>();
        lastOpen = ulong.Parse(PlayerPrefs.GetString("lastOpen"));
        Timer = GetComponentInChildren<Text>();

        if (!isReady())
        {
            Done.SetActive(false);
            RewardButton.interactable = false;
        }
    }

  
    void Update()
    {
        if(!RewardButton.IsInteractable())
        {
            if(isReady())
            {
                Done.SetActive(true);
                RewardButton.interactable = true;
                Timer.text = "Ready";
                return;
            }

            ulong diff = ((ulong)DateTime.Now.Ticks - lastOpen);
            ulong m = diff / TimeSpan.TicksPerMillisecond;
            float seconleft = (float)(msToWait - m) / 1000.0f;

            string t = "";

            t += ((int)seconleft / 3600).ToString() + "h";
            seconleft -= ((int)seconleft / 3600) * 3600;
            t += ((int)seconleft / 60).ToString("00") + "m";
            t += ((int)seconleft % 60).ToString("00") + "s";

            Timer.text = t;
        }
    }

    public void Click()
    {   
        lastOpen = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("lastOpen", lastOpen.ToString());
        Done.SetActive(false);
        RewardButton.interactable = false;
    }

    private bool isReady()
    {
        ulong diff = ((ulong)DateTime.Now.Ticks - lastOpen);
        ulong m = diff / TimeSpan.TicksPerMillisecond;
        float seconleft = (float)(msToWait - m) / 1000.0f;

        if (seconleft < 0)
        {
            Timer.text = "Free";
            return true;

        }
        return false;
    }

    
}
