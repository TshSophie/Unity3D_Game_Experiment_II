using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour {
    GameObject m_ControlCenter;
    public string m_Mystring;
	// Use this for initialization
	void Start () {
        m_ControlCenter = GameObject.Find("GamePointer");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseEnter()
    {
        print("OnMouseEnter");

        m_ControlCenter.SendMessage("CursorCcolorChange", m_Mystring);
    }
    void OnMouseExit()
    {
        m_ControlCenter.SendMessage("CursorCcolorChange", "");
    }
}
