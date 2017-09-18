using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    //Array of SpawnPoints
    public GameObject[] PointsArr = null;
    
    private GameObject CurrentSpawn = null;
    private GameObject PrevSpawn = null;

    private int randNumber = 0;
    
    // Use this for initialization
    void Start ()
    {
        //Changes the spawn of the object when the code begins
        resetSpawn();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Checkis if an object was not active previously before it decides what respawns
        if (!CurrentSpawn.activeInHierarchy)
        {
            //Sets current object to inactive
            CurrentSpawn.SetActive(false);
            //Changes what the current spawn object is
            CurrentSpawn = PrevSpawn;
            //Changes the spawn
            resetSpawn();
            //Respawns it if the object spawns in the same area as the previous object
            if (PrevSpawn == CurrentSpawn)
            {
                //Calls reset method
                resetSpawn();
            }
        }
    }

    //Changes the spawn location of the object
    public void resetSpawn()
    {
        //Randomises the location
        randNumber = Random.Range(0, PointsArr.Length);
        //Makes the random number a value in the array
        CurrentSpawn = PointsArr[randNumber];
        //sets that particular point as the spawn
        CurrentSpawn.SetActive(true);
    }
}
