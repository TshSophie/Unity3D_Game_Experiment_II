using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEvent : MonoBehaviour {
    GameObject m_CurrentDoor;
    RaycastHit m_Hit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Physics.Raycast(transform.position,transform.forward,out m_Hit,2))
        {
            if(m_Hit.collider.gameObject.tag == "PlayerDoor")
            {
                m_CurrentDoor = m_Hit.collider.gameObject;
                m_CurrentDoor.SendMessage("DoorCheck");
            }
        }
	}
}
