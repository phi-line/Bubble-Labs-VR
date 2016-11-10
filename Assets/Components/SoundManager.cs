using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class SoundManager : MonoBehaviour {

    //public AudioSource soundSource;
    public AudioClip clip;
    public int numSources;
    public GameObject soundGenPfb;

    public GameObject parent;

    private List<AudioSource> sources = new List<AudioSource>();

    //random audio
    public float lowPitchRange = .95f;
    public float highPitchRange = 1.05f;

    private int currentAudioIndex;

	// Use this for initialization
	void Awake () {
	}

    void Start() {
        for (int i = 0; i < numSources; ++i) {
            GameObject aus = GameObject.Instantiate(soundGenPfb);
            aus.transform.parent = gameObject.transform;
            AudioSource soundSource = aus.GetComponent<AudioSource>();
            sources.Add(soundSource);
            soundSource.clip = clip;
       } 
    }

    //public void PlaySingle(AudioClip clip)
    //{
    //    soundSource.clip = clip;
    //    soundSource.Play();
    //}

    public void PlayRand(List<AudioClip> clips)
    {
        float randomPitch = UnityEngine.Random.Range(lowPitchRange, highPitchRange);
        int randomSound = UnityEngine.Random.Range(0, clips.Count);
        AudioSource soundSource = sources[currentAudioIndex];
        soundSource.pitch = randomPitch;
        soundSource.clip = clips[randomSound];
        soundSource.Play();
        if (++currentAudioIndex >= sources.Count) {
            currentAudioIndex = 0;
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
