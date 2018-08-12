using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            col.GetComponent<Player>().LoseHealth(50);
        }
    }
    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}
}
