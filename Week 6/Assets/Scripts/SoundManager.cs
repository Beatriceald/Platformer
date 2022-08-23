using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource Music;

    public void SetMusicEnabled(bool Value)
    {
        Music.enabled = Value;
    }

    public void SetVolume(float value)
    {
        AudioListener.volume = value;
    }
}
