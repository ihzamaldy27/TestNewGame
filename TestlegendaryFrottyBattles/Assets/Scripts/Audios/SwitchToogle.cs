using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToogle : MonoBehaviour
{
    [SerializeField] Toggle toggle;


    public bool BGM, SFX;

    private void Start()
    {
        toggle = GetComponent<Toggle>();
        AudioManager audioManager = FindObjectOfType<AudioManager>();
        /*if (BGM)
        {
            toggle.isOn = PlayerPrefs.GetInt("BGMToggle", 1) == 1; // Default to true (1)
        }*/

        //toggle.onValueChanged.AddListener(OnSwitch);

        if (audioManager != null)
        {
            Debug.Log("AudioManager");
        }

        if (BGM)
        {
            if (!AudioManager.Instance.musicSource.mute)
            {
                transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = true;
                toggle.isOn = true;
            }
            else
            {
                transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;
                toggle.isOn = false;
            }

        }

    }

    private void Update()
    {
        /*if (BGM)
        {
            if (!AudioManager.Instance.musicSource.mute)
            {
                OnSwitch(true);
            }
            else
            {
                OnSwitch(false);
            }
        }*/

        /*if (SFX)
        {
            if (!AudioManager.Instance.sfxSource.mute)
            {

                OnSwitch(true);
            }
            else
            {
                OnSwitch(false);
            }
        }*/
    }

    void OnSwitch(bool on)
    {
        transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = on;
    }

    public void toggleOn()
    {
        if (toggle.isOn)
        {
            AudioManager.Instance.musicSource.mute = false;
            transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = true;
        }
        else
        {
            AudioManager.Instance.musicSource.mute = true;
            transform.GetChild(0).GetChild(0).GetComponent<Image>().enabled = false;
        }
    }

}
