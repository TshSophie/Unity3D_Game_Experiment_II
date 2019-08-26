using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCar : MonoBehaviour {
    public GameObject Car;
    private float y;
    private float z;

    void Awake()
    {
        z = this.transform.position.z;
        y = this.transform.position.y;
    }

    void FixedUpdate()
    {
        this.transform.position = new Vector3(Car.transform.position.x + 5, y, z);
        this.transform.LookAt(Car.transform);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
