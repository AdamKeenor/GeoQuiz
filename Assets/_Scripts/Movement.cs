using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public int thrustX = 5;
    public Rigidbody rb = null;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        rb.AddForce(thrustX, 0, 0);
    }

    private void FixedUpdate()
    {

    }
}
