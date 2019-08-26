using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyEvent : MonoBehaviour {
    public Transform m_Target;
    UnityEngine.AI.NavMeshAgent m_Agent;
    
	// Use this for initialization
	void Start () {
        m_Agent = GetComponent<NavMeshAgent>();
        //GameObject ob = GameObject.FindGameObjectWithTag("Tower");
        //m_Target = ob.GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
		if(m_Agent && m_Agent.hasPath)
        {
            m_Agent.SetDestination(m_Target.position);
        }
	}
}
