using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCrystals : MonoBehaviour
{
    public GameObject[] crystals;
    int type;
    void Start ()
    {
		for(int i = 0; i<=50; i++)
        {
            type = Random.Range(0, 4);
            Instantiate(crystals[type], new Vector3(Random.Range(-220, 30), 0, Random.Range(220, -30)), Quaternion.identity);
        }
	}
	
	void Update ()
    {
		
	}
}
