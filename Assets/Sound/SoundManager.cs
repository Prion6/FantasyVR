﻿using System;
using UnityEngine.Audio;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public Sound[] sounds;

    public static SoundManager instance;

    public Timer timer; 

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds )
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        Play("battle theme");
        timer.OnFinish += WinSoundPlay;

    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null)
        {
            return;
        }

        s.source.Play();
    }


    public void WinSoundPlay()
    {
        Sound s = Array.Find(sounds, sound => sound.name == "Winsound");
        if(s == null)
        {
            return;
        }
        s.source.Play();
    }







}
