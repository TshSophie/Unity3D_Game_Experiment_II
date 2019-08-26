using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavMeshLayer : MonoBehaviour {

    public Transform m_Target;
    private NavMeshAgent m_Agent;

	// Use this for initialization
	void Start () {
        m_Agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        if (m_Agent && m_Target)
            m_Agent.SetDestination(m_Target.position);
	}
}
