using UnityEngine;
using System.Collections;
using uFlex;
using System;

public class ColorWheel_OLD : MonoBehaviour
{

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

    //public float shaderRed;
    //public float shaderGreen;
    //public float shaderBlue;


    public Color currentColor;
    private Color augColor;

    void Start()
    {
        //wheelRend = GetComponent<MeshRenderer>();
        //UpdateColor(H_val, S_val, V_val, wheelRend);
        containerManagers = FindObjectsOfType(typeof(ContainerManager)) as ContainerManager[];
    }

    void Update()
    {
        if (wandController.touchpadTouched)
        {
            currentAngle = wandController.GetTouchpadAxisAngle();
            currentAxis = wandController.GetTouchpadAxis();
            //currentTriggerAxis = wandController.triggerAxis;
            currentMagnitude = Mathf.Sqrt(Mathf.Pow(currentAxis.x, 2) + Mathf.Pow(currentAxis.y, 2));
            //Debug.Log(RoundNearest(currentAngle, 30));
            H_val = currentAngle / 360f;
            V_val = currentMagnitude + 0.2f;
            S_val = V_val / 2;
            //if (currentMagnitude >= 0.75f) { V_val = 1.0f ; S_val = 1.0f - currentMagnitude; }
            //else if (currentMagnitude < 0.75f || currentMagnitude >= 0.5) { V_val = 1.0f; S_val = 1.0f; }
            //else if (currentMagnitude < 0.5f) { V_val = currentMagnitude; S_val = 1.0f; }
            UpdateColor(H_val, S_val, V_val, rend);

            //NoteCheck(currentAngle, 30);//, (.2f * currentTriggerAxis.x + .1f));
            //sends angle and note data to sinus controller}   
            //if (currentAngle != lastAngle)
            //{
            //    lastAngle = currentAngle;
            //    NoteCheck(currentAngle, 30);
            //}
        }/* else { NoteCheck(lastAngle, 30); }*/


        //only activate tone when trigger is pressed, but always chack for angle
        //if (currentTriggerAxis.x > 0.05f || flexEmitter.m_alwaysOn) {
        //    sinus.gain = .2f * currentTriggerAxis.x + .1f;
        //        //NoteCheck(currentAngle, 30, (.2f * currentTriggerAxis.x + .1f));
        //} else { sinus.gain = 0; }

        //wheelRend.material.SetFloat("_Red", shaderRed);
    }

    private void UpdateColor(float H, float S, float V, Renderer rend)
    {
        currentColor = Color.HSVToRGB(H, S, V);
        augColor = Color.HSVToRGB(H + 0.02777f, S - 0.1f, V);
        //shaderRed = currentColor.r; shaderGreen = currentColor.g; shaderBlue = currentColor.b;
        flexEmitter.m_color = currentColor;
        flexEmitter.rend.material.color = augColor;
        foreach (ContainerManager conMan in containerManagers)
        {
            conMan.Colors.Liquid.Color = augColor;
            conMan.Colors.Liquid.TopColor = augColor;
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

    //private void NoteCheck(float degree, int multiple)//, float gain)
    //{
    //    int index30 = Convert.ToInt32(RoundNearest(degree, 30));
    //    switch (index30)
    //    {
    //        case 0:
    //            sinus.ChangeNote(Sinus.Keys.C);
    //            break;
    //        case 30:
    //            sinus.ChangeNote(Sinus.Keys.G);
    //            break;
    //        case 60:
    //            sinus.ChangeNote(Sinus.Keys.D);
    //            break;
    //        case 90:
    //            sinus.ChangeNote(Sinus.Keys.A);
    //            break;
    //        case 120:
    //            sinus.ChangeNote(Sinus.Keys.E);
    //            break;
    //        case 150:
    //            sinus.ChangeNote(Sinus.Keys.B);
    //            break;
    //        case 180:
    //            sinus.ChangeNote(Sinus.Keys.Fs);
    //            break;
    //        case 210:
    //            sinus.ChangeNote(Sinus.Keys.Db);
    //            break;
    //        case 240:
    //            sinus.ChangeNote(Sinus.Keys.Ab);
    //            break;
    //        case 270:
    //            sinus.ChangeNote(Sinus.Keys.Eb);
    //            break;
    //        case 300:
    //            sinus.ChangeNote(Sinus.Keys.Bb);
    //            break;
    //        case 330:
    //            sinus.ChangeNote(Sinus.Keys.F);
    //            break;
    //        case 360:
    //            sinus.ChangeNote(Sinus.Keys.C);
    //            break;
    //        default:
    //            Debug.Log("UH-OH! switch case pooped!");
    //            break;
    //    }
    //}
    //http://answers.unity3d.com/questions/701956/hsv-to-rgb-without-editorguiutilityhsvtorgb.html

}
