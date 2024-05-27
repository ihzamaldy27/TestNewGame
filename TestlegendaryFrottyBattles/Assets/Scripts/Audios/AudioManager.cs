using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public Sound[] musicSound, sfxSound;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSound, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not Found!");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    private void Start()
    {
        PlayMusic("BGM");
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSound, x => x.name == name);

        if (s == null)
        {
            Debug.Log("SFX Not Found!");
        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void SetVolumeBGM(Slider value)
    {
        musicSource.volume = value.value;
        Save(value.value);
    }

    void Save(float value)
    {
        PlayerPrefs.SetFloat("BGMVolume", value);
    }

    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }

    public void ToggleSFX()
    {
        sfxSource.mute = !sfxSource.mute;
    }
}
