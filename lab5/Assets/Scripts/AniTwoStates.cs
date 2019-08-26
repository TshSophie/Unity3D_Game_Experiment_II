using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniTwoStates : MonoBehaviour {
    public GameObject m_Aniparent;
    public AnimationClip m_AniclipA;
    public AnimationClip m_AniclipB;

    static int m_objState = 1;
    AnimationClip m_Aniclip;

    void OnMouseOver()
    {
        if(m_objState > 0)
        {
            m_Aniclip = m_AniclipA;
            Invoke("switchState", 3);
        }
        else
        {
            m_Aniclip = m_AniclipB;
            Invoke("switchState", 3);            
        }
       
        print(name + "picked" + m_Aniclip.name);
        m_Aniparent.GetComponent<Animation>().Play(m_Aniclip.name);
    }

    void switchState()
    {
        m_objState = -m_objState;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
