using UnityEngine;
using System.Collections;

[RequireComponent(typeof(LineRenderer))]
public class AddLine : MonoBehaviour {

    LineRenderer line;

    public Transform pointA;
    public Transform pointB;
	// Use this for initialization
	void Start () {
        line = GetComponent<LineRenderer>();
        line.SetVertexCount(2);
        line.SetWidth(.1f, .1f);
        line.useWorldSpace = true;
        line.receiveShadows = false;
        line.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        line.material.color = Color.white;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 start = pointA.position;
        Vector3 end = pointB.position;
        line.SetPosition(0, start);
        line.SetPosition(1, end);
    }
}
