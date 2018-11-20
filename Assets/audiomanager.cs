using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;

public class audiomanager : MonoBehaviour {
    public Sound[] sounds;

	// Use this for initialization
	void Awake () {
        foreach (Sound s in sounds)
        {
            s.source - gameObject.AddComponent<Audiosource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
		
	}
	
	// Update is called once per frame
	public void Play () {
        Array.Find(sounds, sound => sound.name == name);
        sounds.source.Play();
	}
}
