using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEvent : MonoBehaviour {
    AudioSource m_AudioShooting;
    RaycastHit m_RayCast;
    string info = "";
    int m_ScoreCount;
    public ParticleSystem m_BulletEffect;
    public Texture m_ShootingCursor;

	// Use this for initialization
	void Start () {
		m_AudioShooting = this.GetComponent<AudioSource>();
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            m_AudioShooting.Play();
            if(Physics.Raycast(ray,out m_RayCast,100f))
            {
                ParticleSystem obj = Instantiate(m_BulletEffect,m_RayCast.point,Quaternion.Euler(270,0,0));
                obj.Play();
                if (m_RayCast.collider.tag == "Enemy")
                {
                    print(m_RayCast.collider.tag);
                    m_ScoreCount++;
                    info = "Score: " + m_ScoreCount;
                    Destroy(m_RayCast.collider.gameObject);
                }
                Destroy(obj.gameObject, 2);

            }
        }
        
	}

    void OnGUI()
    {        
        GUIStyle m_Style = "";
        m_Style.fontSize = 40;
        m_Style.normal.textColor = Color.red;
        GUILayout.Label(info, m_Style);

        Vector3 vecPos = Input.mousePosition;
        GUI.DrawTexture(
            new Rect(
            vecPos.x-m_ShootingCursor.width/2,
            Screen.height-vecPos.y-m_ShootingCursor.height/2,
            m_ShootingCursor.width,
            m_ShootingCursor.height),
            m_ShootingCursor);

    }

}
