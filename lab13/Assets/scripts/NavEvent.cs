using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavEvent : MonoBehaviour {
    public Transform m_Target;
    private NavMeshAgent m_Agent1;
    
	// Use this for initialization
	void Start () {
        m_Agent1 = this.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        if (m_Agent1 && m_Target)
            m_Agent1.SetDestination(m_Target.transform.position);
	}
}
