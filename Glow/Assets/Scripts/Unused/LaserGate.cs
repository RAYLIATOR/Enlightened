using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGate : MonoBehaviour
{
    bool active;
    public GameObject laserGate;
    public Transform pressedPos;

    void Start ()
    {
        active = true;
	}
	
	void Update ()
    {
		
	}

    public void Deactivate()
    {
        transform.position = pressedPos.position;
        Destroy(laserGate, 0.5f);
        Destroy(gameObject, 0.5f);
    }
}
