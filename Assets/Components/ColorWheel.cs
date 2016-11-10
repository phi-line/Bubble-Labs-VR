using UnityEngine;
using System.Collections;
using uFlex;
using System;

public class ColorWheel : MonoBehaviour {

    public WandController wandController;
    //public Sinus sinus;
    public FlexEmitter flexEmitter; //emitter script
    public Renderer rend; //emitter mesh
    //public Renderer wheelRend; //color wheel renderer
    public ContainerManager[] containerManagers;

    private float H_val;
    private float S_val;
    private float V_val;

    public float offLightness;

    public float currentAngle;
    public float lastAngle;
    private Vector2 currentAxis;
    //private Vector2 currentTriggerAxis;
    private float currentMagnitude;

    public Color currentColor;
    private Color augColor;
    private Color augTopColor;

    void Start() {
        containerManagers = FindObjectsOfType(typeof(ContainerManager)) as ContainerManager[];
    }

    void Update() {
        if (wandController.touchpadTouched)
        {
            currentAngle = wandController.GetTouchpadAxisAngle();
            currentAxis = wandController.GetTouchpadAxis();
            //currentTriggerAxis = wandController.triggerAxis;
            currentMagnitude = Mathf.Sqrt(Mathf.Pow(currentAxis.x, 2) + Mathf.Pow(currentAxis.y, 2));
            //Debug.Log(RoundNearest(currentAngle, 30));
            H_val = currentAngle / 360f;
            S_val = V_val / 1.5f;
            V_val = currentMagnitude + 0.2f;
            UpdateColor(H_val, S_val, V_val, rend);
        }
    }

    private void UpdateColor(float H, float S, float V, Renderer rend) {
        currentColor = Color.HSVToRGB(H, S, V);
        augColor = Color.HSVToRGB(H, S - 0.2f, currentMagnitude + offLightness);
        flexEmitter.m_color = currentColor;
        flexEmitter.rend.material.color = augColor;
        foreach (ContainerManager containerManager in containerManagers)
        {
            containerManager.Colors.Liquid.Color = augColor;
            containerManager.Colors.Liquid.TopColor = augColor;
        }
    }

    private float CalculateTouchpadAxisAngle(Vector2 axis)
    {
        float angle = Mathf.Atan2(axis.y, axis.x) * Mathf.Rad2Deg;
        angle = 90.0f - angle;
        if (angle < 0)
        {
            angle += 360.0f;
        }
        return angle;
    }

    private float RoundNearest(float value, int multiple)
    {
        float rem = value % multiple;
        float result = value - rem;
        if (rem > (multiple / 2))
            result += multiple;
        return result;
    }
    //http://answers.unity3d.com/questions/701956/hsv-to-rgb-without-editorguiutilityhsvtorgb.html

}
