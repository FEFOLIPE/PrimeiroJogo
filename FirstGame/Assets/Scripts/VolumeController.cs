using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public AudioSource musicLevel, musicDead;
    public float musicVolume = 1;
    // Start is called before the first frame update
    void Update()
    {
        musicLevel.volume = musicVolume;
        musicDead.volume = musicVolume;
    }

    public void AjustarVolume(float volume)
    {
        musicVolume = volume;
    }
}
