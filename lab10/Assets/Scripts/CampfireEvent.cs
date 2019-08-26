using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampfireEvent : MonoBehaviour {
    public GameObject m_ComfireFlame;
    bool Islighted;

	// Use this for initialization
	void Start () {
        m_ComfireFlame.SetActive(false);

	}

    void OnMouseEnter()
    {
        if(Islighted == false && MatchEvent.haveMatch)
        {
            print("near");
            m_ComfireFlame.SetActive(true);
            this.GetComponent<AudioSource>().Play();
            Islighted = true;
            MatchEvent.haveMatch = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
