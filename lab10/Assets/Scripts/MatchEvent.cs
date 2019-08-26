using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchEvent : MonoBehaviour {
    public AudioClip collectSound;
    public static bool haveMatch;
    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            haveMatch = true;
            Destroy(gameObject);
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
