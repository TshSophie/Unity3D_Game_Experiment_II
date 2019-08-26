using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEvent : MonoBehaviour {
    public Rigidbody m_Rb;
    public float m_PushPower = 20f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            m_Rb.AddForce(new Vector3(0,0,m_PushPower));
        }
	}
}
