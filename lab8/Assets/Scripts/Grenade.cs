using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {
    public GameObject m_ExpPrefab;
    public float m_Speed = 0.5f;
    float m_CreationTime;
    float m_LifeTime = 1;
	// Use this for initialization
	void Start () {
        m_CreationTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0,0.1f*m_Speed,m_Speed),Space.World);
		if(Time.time > m_CreationTime + m_LifeTime)
        {
            Instantiate(m_ExpPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
	}
}
