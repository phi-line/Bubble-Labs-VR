using UnityEngine;
using System.Collections;

public class MenuAction : MonoBehaviour {

    private bool tweened;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
    }

    public void Select(bool isHover)
    {
        if (isHover)
        {
                iTween.ScaleTo(this.gameObject, new Vector3(1.5f, 1.5f, 1.5f), .5f);
        } else
        {
            iTween.ScaleTo(this.gameObject, new Vector3(1f, 1f, 1f), .5f);
        }
    }
}
