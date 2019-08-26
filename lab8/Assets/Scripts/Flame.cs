using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour {

    public ParticleSystem m_Torch;
    void OnMouseEnter()
    {
        print("hello");
        m_Torch.Play();
    }


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
