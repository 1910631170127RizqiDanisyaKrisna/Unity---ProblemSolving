using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip eat;
    private AudioSource audioPlayer;
    void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void Eat()
    {
        audioPlayer.PlayOneShot(eat);
    }
}
