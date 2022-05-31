﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnSpace : MonoBehaviour
{
    public AudioClip aaa;
    AudioSource fuenteAudio;
    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            fuenteAudio.clip = aaa;
            fuenteAudio.Play();
        }
    }
}
