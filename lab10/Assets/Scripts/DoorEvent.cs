using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEvent : MonoBehaviour {
    bool m_DoorIsOpen = false;
    float m_DoorTimer = 0.0f;
    public float m_DoorOpenTime = 3.0f;
    public AudioClip m_DoorOpenSound;
    public AudioClip m_DoorShutSound;

	// Use this for initialization
	void Start () {
        if (m_DoorIsOpen)
        {
            m_DoorTimer += Time.deltaTime;
            if (m_DoorTimer > m_DoorOpenTime)
            {
                Door(m_DoorShutSound, false, "DoorShut");
                m_DoorTimer = 0.0f;
            }
        }
	}

    void DoorCheck()
    {
        if (!m_DoorIsOpen)
            Door(m_DoorOpenSound,true,"DoorOpen");
    }

	void Door(AudioClip aclip,bool openCheck,string aniName)
    {
        GetComponent<AudioSource>().PlayOneShot(aclip);
        m_DoorIsOpen = openCheck;
        this.transform.parent.gameObject.GetComponent<Animation>().Play(aniName);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
