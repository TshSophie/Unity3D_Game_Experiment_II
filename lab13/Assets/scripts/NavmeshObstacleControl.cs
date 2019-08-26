using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavmeshObstacleControl : MonoBehaviour {
    private UnityEngine.AI.NavMeshObstacle _navMeshObs;
    
	// Use this for initialization
	void Start () {
        _navMeshObs = this.GetComponent<UnityEngine.AI.NavMeshObstacle>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            if(_navMeshObs)
            {
                _navMeshObs.enabled = false;
                this.GetComponent<Renderer>().material.color = Color.green;
            }
        }
        if (Input.GetButtonUp("Fire1"))
        {
            if (_navMeshObs)
            {
                _navMeshObs.enabled = true;
                this.GetComponent<Renderer>().material.color = Color.red;
            }
        }

	}
}
