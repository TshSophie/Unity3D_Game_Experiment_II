using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathEvent : MonoBehaviour {

    public Transform m_Target;
    private NavMeshAgent m_Agent;

    // Use this for initialization
    void Start()
    {
        GameObject ob = GameObject.FindGameObjectWithTag("Tower");
        m_Target = ob.GetComponent<Transform>();
        m_Agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Agent && m_Target)
            m_Agent.SetDestination(m_Target.position);
    }
}
