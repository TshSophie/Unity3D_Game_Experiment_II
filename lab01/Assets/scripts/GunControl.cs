using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour {
    public float m_speed = 2f;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Mouse X") * m_speed;
        float vertical = Input.GetAxis("Mouse Y") * 0.7f * m_speed;
        transform.Rotate(0, horizontal, 0, Space.World);
        transform.Rotate(-vertical, 0, 0,  Space.Self);

	}
}
