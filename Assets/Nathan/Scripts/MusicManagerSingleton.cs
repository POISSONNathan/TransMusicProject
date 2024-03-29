using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagerSingleton : MonoBehaviour
{
    public static MusicManagerSingleton Instance;
    public AudioSource sfxAudioSource, sfxAudioSource2, sfxAudioSource3, musicAudioSource;
    public List<AudioSound> sounds;
    public bool activeAides = true;
    
    private void Awake()
    {
        if (MusicManagerSingleton.Instance == null)
        {
            MusicManagerSingleton.Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(string soundName)
    {
        AudioClip audioToPlay = null;
        foreach (var audioSound in sounds)
        {
            if (audioSound.Name == soundName)
            {
                audioToPlay = audioSound.Clip;
            }
        }

        sfxAudioSource.clip = audioToPlay;
        sfxAudioSource.Play();
    }
    public void PlaySound2(string soundName)
    {
        AudioClip audioToPlay = null;
        foreach (var audioSound in sounds)
        {
            if (audioSound.Name == soundName)
            {
                audioToPlay = audioSound.Clip;
            }
        }

        sfxAudioSource2.clip = audioToPlay;
        sfxAudioSource2.Play();
    }
    public void PlaySound3(string soundName)
    {
        AudioClip audioToPlay = null;
        foreach (var audioSound in sounds)
        {
            if (audioSound.Name == soundName)
            {
                audioToPlay = audioSound.Clip;
            }
        }

        sfxAudioSource3.clip = audioToPlay;
        sfxAudioSource3.Play();
    }
    public void PlayMusic()
    {
        musicAudioSource.Play();
    }
}

[System.Serializable]
public struct AudioSound
{
    public string Name;
    public AudioClip Clip;
}