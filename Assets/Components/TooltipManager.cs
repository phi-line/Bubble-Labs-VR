using UnityEngine;
using System.Collections;
using System;

public class TooltipManager : MonoBehaviour {
    public WandController wandConL;
    public WandController wandConR;

    public GameObject ttLeft;
    public GameObject ttRight;

    private bool ttToggle;

    void Awake() {
        ToggleMenu(true);
    }

    // Use this for initialization
    void Start () {
        wandConL.ApplicationMenuPressed += (object sender, ControllerInteractionEventArgs e) =>
        {
            ttToggle = !ttToggle;
            ToggleMenu(ttToggle);
        };
        wandConR.ApplicationMenuPressed += (object sender, ControllerInteractionEventArgs e) =>
        {
            ttToggle = !ttToggle;
            ToggleMenu(ttToggle);
        };
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void ToggleMenu(bool ToggleOn) {
        int mult = Convert.ToInt32(ToggleOn);
        iTween.ScaleTo(ttLeft, new Vector3(1f, 1f, 1f) * mult, 0.5f);
        iTween.ScaleTo(ttRight, new Vector3(1f, 1f, 1f) * mult, 0.5f);
    }
}
