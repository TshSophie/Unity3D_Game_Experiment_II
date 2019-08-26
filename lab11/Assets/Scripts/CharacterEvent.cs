using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEvent : MonoBehaviour {
    public Rigidbody m_Rb1;
    public Rigidbody m_Rb2;
    public float m_Speed1 = 100;
    public float m_Speed2 = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            m_Rb1.AddForce(new Vector3(-1 * m_Speed1, 1 * m_Speed1, 0));
        }
        if (Input.GetMouseButtonDown(1))
        {
            m_Rb2.AddForce(new Vector3(-1 * m_Speed1, 1 * m_Speed2, 0));
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_Rb1.AddForce(new Vector3(0,0,-1*m_Speed2));
            m_Rb2.AddForce(new Vector3(0,0,1*m_Speed2));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_Rb2.AddForce(new Vector3(0, 0, -1 * m_Speed2));
            m_Rb1.AddForce(new Vector3(0, 0, 1 * m_Speed2));
        }
	}
}
