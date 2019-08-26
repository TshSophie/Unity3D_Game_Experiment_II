using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomCursor : MonoBehaviour {
    public Color m_mouseOverColor = Color.red;
    public Text m_Mytext;
	// Use this for initialization
	void Start () {
       // Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        var pos = Input.mousePosition;
        GetComponent<GUITexture>().pixelInset = new Rect(pos.x, pos.y - 32, 32, 32);
	}

    void CursorCcolorChange(string Mystring)
    {
        if (Mystring != "")
        {
            GetComponent<GUITexture>().color = m_mouseOverColor;
            m_Mytext.text = Mystring;
        }
        else
        {
            GetComponent<GUITexture>().color = Color.white;
            m_Mytext.text = "";
        }
    }
}
