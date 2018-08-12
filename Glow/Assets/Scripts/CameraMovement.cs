using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    float height;
	void Start ()
    {
        height = 20f;
	}
	void Update ()
    {
        transform.position = new Vector3(target.position.x, target.position.y + height, target.position.z-10f);
	}
}
