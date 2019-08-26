using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakEnemy : MonoBehaviour {
    public Transform m_Target;
    public GameObject m_PerfabEnemy;
    public float m_MakeTime = 3;

    void make()
    {
        GameObject obj = Instantiate(m_PerfabEnemy,transform.position,transform.rotation) as GameObject;
        obj.GetComponent<EnemyEvent>().m_Target = m_Target;
        Invoke("make",m_MakeTime);
    }
	// Use this for initialization
	void Start () {
        Invoke("make",m_MakeTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
