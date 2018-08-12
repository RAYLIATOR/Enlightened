using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{    
	void Start ()
    {
		
	}
	void Update ()
    {
        transform.Rotate(new Vector3(0,1,0));
	}
}
