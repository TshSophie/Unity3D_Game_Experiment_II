using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniControl : MonoBehaviour {
    Animator myAnimator;
    Transform myCarema;
	// Use this for initialization
	void Start () {
        myAnimator = GetComponent<Animator>();
        myCarema = GameObject.Find("Main Camera").transform;
	}
	
	// Update is called once per frame
	void Update () {
        myCarema.position = transform.position + new Vector3(0, 1.5f, 5);
        myCarema.LookAt(transform);
	}

    public void ButtonOneClick(int index)
    {
        myAnimator.SetFloat("AniFlag",index);
    }
}
