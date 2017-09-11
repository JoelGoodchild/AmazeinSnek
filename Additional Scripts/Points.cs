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
        resetSpawn();
        //CurrentSpawn.GetComponent<SpawnInteraction>().SpawnObject();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!CurrentSpawn.activeInHierarchy)
        {
            CurrentSpawn.SetActive(false);
            CurrentSpawn = PrevSpawn;
            resetSpawn();
            if (PrevSpawn == CurrentSpawn)
            {
                resetSpawn();
            }
        }
    }

    public void resetSpawn()
    {
        randNumber = Random.Range(0, PointsArr.Length);
        CurrentSpawn = PointsArr[randNumber];
        CurrentSpawn.SetActive(true);
    }
}
