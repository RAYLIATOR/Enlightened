using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerShot : MonoBehaviour
{
    float speed;
    Vector3 target;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Box")
        {
            Destroy(gameObject);
        }
        if (col.tag == "Enemy")
        {
            col.GetComponent<Enemy>().TakeDamage();
            Destroy(gameObject);
        }
        if (col.tag == "LaserSwitch")
        {
            col.GetComponent<LaserGate>().Deactivate();
            Destroy(gameObject);
        }
        if (col.tag == "Terrain")
        {
            Destroy(gameObject);
        }
    }
	void Start ()
    {
        speed = 0.8f;
        target = new Vector3(Player.pointToLookAt.x, Player.pointToLookAt.y, Player.pointToLookAt.z);
        transform.LookAt(new Vector3(target.x, transform.position.y, target.z));
    }
	void Update ()
    {
        transform.position += transform.forward * speed;
	}
}
