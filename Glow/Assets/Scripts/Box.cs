using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    bool special;
    int type;
    GameObject player;
    Renderer boxRend;
    //public Material regMat;
    //public Material ammoMat;
    //public Material HealthMat;
    float health = 100f;
    int orbType;
    public GameObject boxPowerShot;
    public GameObject yellowOrb;
    public GameObject redOrb;
    public GameObject explosion;
    GameObject currentOrb;
    void Start()
    {
        boxRend = GetComponent<Renderer>();
        type = Random.Range(1, 4);
        switch(type)
        {
            case 1:
                //boxRend.material = regMat;
                special = true;
                currentOrb = yellowOrb;
                break;
            case 2:
                //boxRend.material = regMat;
                special = true;
                currentOrb = yellowOrb;
                break;
            case 3:
                //boxRend.material = regMat;
                special = true;
                currentOrb = redOrb;
                break;
        }
        player = GameObject.FindGameObjectWithTag("Player");
        /*orbType = Random.Range(1, 5);
        switch (orbType)
        {
            case 1:
                currentOrb = yellowOrb;
                break;
            case 2:
                currentOrb = yellowOrb;
                break;
            case 3:
                currentOrb = yellowOrb;
                break;
            case 4:
                currentOrb = redOrb;
                break;
        }*/
    }
    void Update()
    {

    }
    public void LoseHealth()
    {
        health -= 50;
        if (health == 0)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Invoke("Die", 0.1f);
        }
    }
    void Die()
    {
        if (special)
        {
            Instantiate(currentOrb, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
