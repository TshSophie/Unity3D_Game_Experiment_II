using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniRetControl : MonoBehaviour {
    Animator myAnimator;
    Transform myCamara;
    Animator EthanAnimator;
	// Use this for initialization
	void Start () {
        myAnimator = GetComponent<Animator>();
        myCamara = GameObject.Find("Main Camera").transform;
        EthanAnimator = GameObject.Find("Ethan").GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        myCamara.position = transform.position + new Vector3(0,1.5f,4);
        myCamara.LookAt(transform);
	}

    public void ButtonOnclick(int index)
    {
       if(index == 3)
       {
           myAnimator.SetInteger("BlendFlag", index);
           EthanAnimator.SetInteger("BlendFlag", index);
       }
       else
       {
           bool[] pars = { true, false };
           myAnimator.SetBool("JtoR", pars[index]);
           myAnimator.SetBool("RtoJ", pars[(index + 1) % 2]);

           EthanAnimator.SetBool("JtoR", pars[index]);
           EthanAnimator.SetBool("RtoJ", pars[(index + 1) % 2]);
       }
    }
}
