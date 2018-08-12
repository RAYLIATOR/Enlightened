using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPowershot : MonoBehaviour
{
    float speed = 9f;
    GameObject target;
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Box")
        {
            target.GetComponent<Box>().LoseHealth();
            Destroy(gameObject);
        }
    }
	void Start ()
    {
        //target = Player.boxTarget;
        transform.Rotate(-90, 0, 0);
        transform.LookAt(target.transform.position);
	}
	void Update ()
    {
        if(target == null)
        {
            Destroy(gameObject);
        }
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
	}
}
