using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherChange : MonoBehaviour {

    public Light Shadow;
    public WindZone wind;
    public Material Darkstorm;
    AudioSource thunder;
	// Use this for initialization
	void Start () {
        thunder = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetButtonDown("Fire1"))
        {
            thunder.Play();
            wind.windTurbulence = 20;
            wind.windPulseMagnitude = 3;

            Invoke("SkyChange",5f);
        }
	}

    void SkyChange()
    {
        RenderSettings.skybox = Darkstorm;
        Shadow.shadows = 0;
    }
}
