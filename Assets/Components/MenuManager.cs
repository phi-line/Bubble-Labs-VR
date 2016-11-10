using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;



public class MenuManager : MonoBehaviour
{
    

    public uFlex.FlexSolver flexSolver;
    public WandController wandConL;
    public SoundManager soundMan;
    public HapticsManager hapMan;
    public Transform mainCamera;
    public GameObject activeItem;

    public List<AudioClip> clips = new List<AudioClip>();

    //clear
    public GameObject clearCollider;
    public uFlex.FlexEmitter clearEmitter;
    public float clearTime;

    //menu items
    public MenuAction itemItem;
    public MenuAction itemGIF;
    public MenuAction itemClear;

    private bool MenuToggleOn;
    //private bool FreezeToggleOn;


    public float roundTri;

    private bool isHover;
    List<GameObject> menuChildren = new List<GameObject>();

    private struct Button {
        public ButtonType buttonType;
        public MenuAction menuAction;
        public Button(ButtonType _buttonType, MenuAction _menuAction) {
            buttonType = _buttonType;
            menuAction = _menuAction;
        }
    }

    private Button buttonItem;
    private Button buttonGIF;
    private Button buttonClear;

    private enum ButtonType
    {
        None,
        Item,
        GIF,
        Clear
    }
    private Button button;
    private Button lastButton;

    void Awake() {
        foreach (AudioClip a in Resources.LoadAll("Audio/Drops", typeof(AudioClip)))
        {
            clips.Add(a);
        }
    }

    // Use this for initialization
    void Start()
    {
        button = new Button();
        buttonItem = new Button(ButtonType.Item, itemItem);
        buttonGIF = new Button(ButtonType.GIF, itemGIF);
        buttonClear = new Button(ButtonType.Clear, itemClear);
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("menuItem")) {
            menuChildren.Add(go);
        }
        //Debug.Log(menuChildren);
        MenuToggleOn = false;
        wandConL.TouchpadTouchStart += (object sender, ControllerInteractionEventArgs e) =>
        {
            MenuToggleOn = true;
            ScaleUs(menuChildren, MenuToggleOn);
        };
        wandConL.TouchpadTouchEnd += (object sender, ControllerInteractionEventArgs e) =>
        {
            MenuToggleOn = false;
            ScaleUs(menuChildren, MenuToggleOn);
        };
        wandConL.TouchpadPressed += (object sender, ControllerInteractionEventArgs e) =>
        {
            //soundMan.PlayRand(clips);
            switch (button.buttonType) {
                case (ButtonType.Item):
                    Debug.Log("Item Change ACTIVATE");
                    break;
                case (ButtonType.GIF):
                    //FreezeToggleOn = !FreezeToggleOn;
                    //Freeze(FreezeToggleOn);
                    //Debug.Log("Freeze ACTIVATE" + FreezeToggleOn);
                    Debug.Log("Record GIF Activate");
                    break;
                case (ButtonType.Clear):
                    StartCoroutine(Clear(clearTime));
                    soundMan.PlayRand(clips);
                    Debug.Log("Clear ACTIVATE");
                    break;
                default:
                    break;
            }
        };
    }

    //scaling multplier
    public void ScaleUs(List<GameObject> children,  bool ToggleOn)
    {
        int mult = Convert.ToInt32(ToggleOn);
        float itemMult = 0;
        if (mult == 0) {itemMult = 0.75f; }
        iTween.ScaleTo(this.gameObject, new Vector3(1f, 1f, 1f) * mult, 0.5f);
        //iTween.ScaleTo(activeItem, new Vector3(1f, 1f, 1f) * (1 - mult), 0.5f);       
        iTween.ScaleTo(activeItem, new Vector3(1f, 1f, 1f) * (itemMult + 0.25f), 0.5f);
        foreach (GameObject child in children)
        {
            iTween.ScaleTo(child, new Vector3(1f, 1f, 1f) * mult, 1.0f);
        }
    }

    void FixedUpdate() {
        //Vector3 targetPosition = new Vector3(mainCamera.transform.rotat.x,
        //                   mainCamera.transform.position.y,
        //                   mainCamera.transform.position.z + 180f);
        //transform.rotation = Quaternion.LookRotation(targetPosition);
        //transform.LookAt(mainCamera.position, mainCamera.up);
    }

    // Update is called once per frame
    void Update()
    {        
        if (MenuToggleOn)
            {
                roundTri = RoundNearest(wandConL.GetTouchpadAxisAngle(), 120);
                if (roundTri == 360) { roundTri = 0; }
            //Debug.Log(buttonType + " " + lastButtonType);
                if (lastButton.buttonType != button.buttonType) {
                    Reset();
                }
                lastButton = button;
                switch ((int)roundTri)
                {
                    case 0: //tutorial
                        //itemTutorial.Select(true);
                        button = buttonItem;
                        break;
                    case 120: //freeze     
                        //itemFreeze.Select(true);
                        button = buttonGIF;
                        break;
                    case 240: //clear
                        //itemClear.Select(true);
                        button = buttonClear;
                        break;
                    default:
                        button.buttonType = ButtonType.None;
                        break;
                }
                
            }
    }
    

    private float RoundNearest(float value, int multiple)
        {
        float rem = value % multiple;
        float result = value - rem;
        if (rem > (multiple / 2)) { result += multiple; }
        return result;
        }

    private void Reset()
    {            
            foreach (GameObject go in menuChildren)
            {
                if (button.menuAction == go.GetComponent<MenuAction>()) { continue; }
                go.GetComponent<MenuAction>().Select(false);
            }
        button.menuAction.Select(true);
    }

    IEnumerator Clear(float timeToClear)
    {
        //iTween.ScaleTo(clearCollider.gameObject, new Vector3(2f, 2f, 2f), 1f);
        //yield return new WaitForSeconds(timeToClear);
        //iTween.ScaleTo(clearCollider.gameObject, Vector3.zero, .1f);
        clearEmitter.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        clearEmitter.gameObject.SetActive(false);
    }

    private void Freeze(bool FreezeToggleOn) {
        if (FreezeToggleOn) { flexSolver.m_solverSubSteps = 0; } else { flexSolver.m_solverSubSteps = 1; }
    }

}
