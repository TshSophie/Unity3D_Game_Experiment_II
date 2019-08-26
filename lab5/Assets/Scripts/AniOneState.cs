using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniOneState : MonoBehaviour {
    public GameObject m_Aniparent;
    public AnimationClip m_Aniclip;

    void OnMouseOver()
    {
        print(name + "picked" + m_Aniclip.name);
        m_Aniparent.GetComponent<Animation>().Play(m_Aniclip.name);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
