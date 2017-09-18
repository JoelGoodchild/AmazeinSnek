using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    // Use this for initialization
    void Awake ()
    {
        //Sets Object to inactive by default, points script controls whether it is active or not
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        //If there is a collisoin it sets the pickup object to inactive
        gameObject.SetActive(false);
    }
}
