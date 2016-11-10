using UnityEngine;
using System.Collections;
using System;

public class HapticsManager : MonoBehaviour {

    public SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    public SteamVR_TrackedObject trackedObj;

    //public WandController wandController;
    //private float currentTriggerAxis;

    void Start() {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    void Update() {
        //currentTriggerAxis = wandController.triggerAxis.x;

    }


    public void GradientPulse(float strength)
    {
            controller.TriggerHapticPulse((ushort)Mathf.Lerp(0, 3999, strength));  
    }

    public void HapticsDispatcher(string pulseType, float strength, float length = 0, float gaplength = 0, int vibrationCount = 0) {
        switch (pulseType)
        {
            case "single":
                SinglePulse(strength);
                //Debug.Log("----------------SINGLE BREAK-----------------");
                break;
            case "singleDelayed":
                StartCoroutine(SingleDelayedPulse(strength, gaplength));
                //Debug.Log("----------------SINGLE DELAYED BREAK-----------------");
                break;
            case "long":
                StartCoroutine(LongPulse(strength, length)); //LongPulse(strength, length);
                //Debug.Log("----------------LONG BREAK-----------------");
                break;
            case "delayed":
                StartCoroutine(LongPulse(strength, length));
                //Debug.Log("----------------DELAYED BREAK-----------------");
                break;
            case "longDelayed":
                StartCoroutine(LongDelayedPulse(strength, length, gaplength));
                //Debug.Log("----------------LONG DELAYED BREAK-----------------");
                break;
            case "pulsed":
                StartCoroutine(PulsedVibration(strength, length, gaplength, vibrationCount));
                //Debug.Log("----------------PULSED BREAK-----------------");
                break;
            default:
                //Debug.Log("----------------DEFAULT BREAK-----------------");
                break;
        }
    }

    public void SinglePulse(float strength)
    {
        controller.TriggerHapticPulse((ushort)Mathf.Lerp(0, 3999, strength));
    }

    IEnumerator SingleDelayedPulse(float strength, float gapLength)
    {
        SinglePulse(strength);
        yield return new WaitForSeconds(gapLength);
    }

    //length is how long the vibration should go for; strength is vibration strength from 0-1
    IEnumerator LongPulse(float strength, float length)
    {
        SinglePulse(strength);
        for (float i = 0; i < length; i += Time.deltaTime)
        {
            SinglePulse(strength);
            yield return null;
        }
    }

    //Repeats pulse for a set ammt of time
    //public void LongPulse(float strength, float length) {
    //    InvokeRepeating("SinglePulse", length, 0.1f);
    //}

    IEnumerator LongDelayedPulse(float strength, float length, float gapLength)
    {
        for (float i = 0; i < length; i += Time.deltaTime)
        {
            SinglePulse(strength);
            yield return new WaitForSeconds(gapLength);
        }
    }

    //public void DelayedPulse(float strength, float length, float gapLength) {
    //    InvokeRepeating("SinglePulse", length, gapLength);
    //}

    //strength is vibration strength from 0-1; length is how long each vibration should go for
    //gapLength is how long to wait between vibrations;  vibrationCount is how many vibrations
    IEnumerator PulsedVibration(float strength, float length, float gapLength, int vibrationCount)
    {
        strength = Mathf.Clamp01(strength);
        for (int i = 0; i < vibrationCount; i++)
        {
            if (i != 0) yield return new WaitForSeconds(gapLength);
            yield return StartCoroutine(LongPulse(strength, length));
        }
    }
}

