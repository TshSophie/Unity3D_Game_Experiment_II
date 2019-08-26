using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour {
    public GameObject wheel;
    private float wheelAngle;
    private WheelCollider wheelCollder;

    void Awake()
    {
        wheelCollder = wheel.transform.GetComponent<WheelCollider>();
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.rotation = wheelCollder.transform.rotation * Quaternion.Euler(wheelAngle,0, 0 );
        wheelAngle += wheelCollder.rpm * 360 / 60 * Time.deltaTime;
	}
}
