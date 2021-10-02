using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOneShot : MonoBehaviour 
{
    public AudioClip sound;
    public AudioSource soundSource;

    void Start() {
        soundSource = GetComponent<AudioSource>();
    }

    public void play() //여러번 눌러도 한번만 재생하도록 함
    {
            if (soundSource.isPlaying) return;
            else
                soundSource.PlayOneShot(sound);

    }
}
