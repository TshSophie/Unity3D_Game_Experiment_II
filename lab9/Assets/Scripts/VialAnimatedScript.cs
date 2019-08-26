using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VialAnimatedScript : MonoBehaviour {
    public GameObject m_VialAnimatedPerfab;
    bool State = true;
    public Animation m_FlowerActive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(State)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject obj = Instantiate(m_VialAnimatedPerfab, transform.position, Quaternion.identity) as GameObject;
                obj.transform.Rotate(new Vector3(-90, 0, 0), Space.World);
                Invoke("FlowerEvent", 3f);
                State = false;
            }
        }
	}

    void FlowerEvent()
    {
        m_FlowerActive.Play();
    }
}
