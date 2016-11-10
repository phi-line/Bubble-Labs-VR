using UnityEngine;
using System.Collections;

public class LookAtMe : MonoBehaviour {

    public Transform mainCamera;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetPosition = new Vector3(mainCamera.transform.position.x,
                               mainCamera.transform.position.y,
                               mainCamera.transform.position.z);
        transform.rotation = Quaternion.LookRotation(transform.position - targetPosition);
    }
}
