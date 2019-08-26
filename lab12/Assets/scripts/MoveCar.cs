using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour {
    public GameObject BRWheel;
    public GameObject BLWheel;
    public float maxtorque = 3000;
    public float maxSteerAngle = 30f;

    public TrailRenderer first;
    public TrailRenderer second;

    void FixedUpdate()
    {
       
        float speed = Input.GetAxis("Vertical");        
        if(speed > 0)
        {
            first.enabled = false;
            second.enabled = false;
            BRWheel.GetComponent<WheelCollider>().brakeTorque = 0;
            BLWheel.GetComponent<WheelCollider>().brakeTorque = 0;
            BRWheel.GetComponent<WheelCollider>().motorTorque = maxtorque * speed;
            BLWheel.GetComponent<WheelCollider>().motorTorque = maxtorque * speed;
            print(BRWheel.GetComponent<WheelCollider>().motorTorque);
        }
        else
        {
            first.enabled = true;
            second.enabled = true;
            BRWheel.GetComponent<WheelCollider>().brakeTorque = maxtorque*speed*2;
            BLWheel.GetComponent<WheelCollider>().brakeTorque = maxtorque*speed*2;
            BRWheel.GetComponent<WheelCollider>().motorTorque = 0;
            BLWheel.GetComponent<WheelCollider>().motorTorque = 0;
        }

        float streerspeed = Input.GetAxis("Horizontal");
        BRWheel.GetComponent<WheelCollider>().steerAngle = maxSteerAngle * streerspeed*-1;
        BLWheel.GetComponent<WheelCollider>().steerAngle = maxSteerAngle * streerspeed * 1;

    }
	
}
