using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPlatform : MonoBehaviour
{
    public GameObject enemy;
    Renderer rend;
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            SpawnBoss();
        }
    }

    void Start ()
    {
        rend = GetComponent<Renderer>();
	}
	void Update ()
    {
		
	}
    void SpawnBoss()
    {
        Instantiate(enemy, new Vector3(-93, -12.25f, 94), Quaternion.identity);
    }
}
