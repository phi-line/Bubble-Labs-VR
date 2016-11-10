using UnityEngine;
using System.Collections;
using System;

public class Draggable : MonoBehaviour
{
    public Transform attatchPoint;
    public WandController wandController;

    public new Rigidbody rigidbody;

    private Vector3 origin;
    public float forceConstant = 200.0f;
    private bool returning = false;
    public float precision = 0.1f;

    public float speed = 9.0f;
    private Vector3 targetPos;

    private void Awake()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        returning = true;
    }

    private void FixedUpdate() {
        origin = attatchPoint.position;
    }

    private void Update()
    {
        //if (wandController.gripPressed)
        //{
        //    transform.position = leftHand.transform.position;
        //    transform.localRotation = leftHand.transform.localRotation;
        //}
        //if (!wandController.gripPressed)
        //{
        //    returning = true;
        //    rigidbody.constraints = RigidbodyConstraints.None;
        //}

        //transform.position = attatchPoint.transform.position;
        //transform.rotation = attatchPoint.transform.rotation;
        if (wandController) {
            //float distance = transform.position.z - Camera.main.transform.position.z;
            targetPos = new Vector3(attatchPoint.position.x, attatchPoint.position.y, attatchPoint.position.z);
            //targetPos = Camera.main.ScreenToWorldPoint(targetPos);
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            transform.rotation = attatchPoint.transform.rotation;
        }

        if (returning)
        {
            GetComponent<Rigidbody>().AddForce(forceConstant * (origin - transform.position));
            GetComponent<Rigidbody>().velocity *= 0.9f;
            if (GetComponent<Rigidbody>().velocity.magnitude < precision &&
                Vector3.Distance(transform.position, origin) < precision) {
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                returning = false;
            }
        }
    }
}