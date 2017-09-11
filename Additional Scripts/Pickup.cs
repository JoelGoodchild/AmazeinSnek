using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    // Use this for initialization
    void Awake () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
        
        //If delay required
        //Invoke("Respawn", 5);
    }

    public void Respawn()
    {
        gameObject.SetActive(false);
    }
}
