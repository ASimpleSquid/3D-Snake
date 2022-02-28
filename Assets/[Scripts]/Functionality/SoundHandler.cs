using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{
    private AudioSource[] mySounds;

    private AudioSource bite;
    void Start()
    {
        mySounds = GetComponents<AudioSource>();
        bite = mySounds[0];

    }

    public void PlayBite()
    {
        bite.Play();
    }
}
