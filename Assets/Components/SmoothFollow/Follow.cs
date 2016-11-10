using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Follow : MonoBehaviour
{

    private Rigidbody rb;

    public GameObject target;
    //public Transform com;
    public float springConstant;
    public float dampingConstant;
    public float targetRadius;

    public bool matchOnceInRadius;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.centerOfMass += com.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (!target) { return; }

        Vector3 position = target.transform.position;
        Vector3 toTarget = position - transform.position;

        //always sets rotation
        transform.rotation = target.transform.rotation;

        if (toTarget.sqrMagnitude < targetRadius)
        {

            rb.velocity = Vector3.zero;

            if (matchOnceInRadius)
            {
                transform.position = target.transform.position;
            }

            return;
        }

        // we want to calculate dF/dt rather than just F because this happens every time step

        float k = springConstant;
        float b = dampingConstant;
        float m = rb.mass;

        Vector3 dFdt = ((k * b) / m) * toTarget - (Mathf.Pow(b, 2.0f) / m + k) * rb.velocity;

        rb.AddForce(dFdt * Time.fixedDeltaTime);
        //sets parents transform to be the same as childs
        //transform.parent.position = transform.position - transform.localPosition;
    }
}