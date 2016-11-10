using UnityEngine;
using System;  // Needed for Math

[RequireComponent (typeof(AudioSource))]

public class Sinus : MonoBehaviour
{
    // un-optimized version
    public bool playNote = true;

    public int octave;
    private double frequency; // = 440;
    public double gain;// = 0.05;

    private double increment;
    private double phase;
    private double sampling_frequency = 48000;

    private int a4 = 55;

    public enum Keys
    {
        C  = -9,
        Db = -8,
        D  = -7,
        Eb = -6,
        E  = -5,
        F  = -4,
        Fs = -3,
        G  = -2,
        Ab = -1,
        A  =  0,
        Bb =  1,
        B  =  2,
    }

    void OnAudioFilterRead(float[] data, int channels)
    {
        if (playNote)
        {
            //Debug.Log("ON AUDIO FILTER READ");
            //update increment in case frequency has changed
            //increment = frequency * 2 * Math.PI / sampling_frequency;
            for (var i = 0; i < data.Length; i = i + channels)
            {
                phase = phase + increment;
                // this is where we copy audio data to make them “available” to Unity
                data[i] = (float)(gain * Math.Sin(phase));
                // if we have stereo, we copy the mono data to each channel
                if (channels == 2) data[i + 1] = data[i];
                if (phase > 2 * Math.PI) phase = 0;
            }
        }
    }

    //returns frequency of given note and octave
    public void ChangeNote (Keys keys, int octave = 2) {
        //gain = setGain;
        int keyIndex = (int)keys;
        increment = (Mathf.Pow(2, (keyIndex / 12f)) * a4) * (octave) * Math.PI / sampling_frequency;
    }
}