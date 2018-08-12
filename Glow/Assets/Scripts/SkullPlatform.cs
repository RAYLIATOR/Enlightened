using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullPlatform : MonoBehaviour
{
    public GameObject enemy;
    Renderer rend;
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            SpawnEnemies();
        }
    }

    void Start ()
    {
        rend = GetComponent<Renderer>();
	}
	void Update ()
    {
		
	}
    void SpawnEnemies()
    {
        for(int i = 0; i <= 10; i++)
        {
            Instantiate(enemy, new Vector3(transform.position.x + Random.Range(-30, 30), -5, transform.position.z + Random.Range(-30, 30)), Quaternion.identity);
        }
    }
}
