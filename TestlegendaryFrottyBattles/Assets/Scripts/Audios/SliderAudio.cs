using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SliderAudio : MonoBehaviour
{
    [SerializeField] Slider sliderVolume;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("BGMVolume"))
        {
            PlayerPrefs.SetFloat("BGMVolume", 1);
            LoadVolume();
        }
        else
        {
            LoadVolume();
        }
    }

    public void SetVolume()
    {
        AudioManager.Instance.musicSource.volume = sliderVolume.value;
        SaveVolume();
    }

    private void SaveVolume()
    {
        PlayerPrefs.SetFloat("BGMVolume", sliderVolume.value);
    }

    private void LoadVolume()
    {
        AudioManager.Instance.musicSource.volume = PlayerPrefs.GetFloat("BGMVolume");
        sliderVolume.value = AudioManager.Instance.musicSource.volume;
    }
}
