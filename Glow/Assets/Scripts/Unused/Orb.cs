using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    GameObject player;
    float distanceToPlayer;
    float attractRange;
    float speed;
    void OnTriggerEnter(Collider col)
    {
        /*if(col.tag == "Player" && gameObject.tag == "YellowOrb")
        {
            if(col.GetComponent<Player>().playerPower == 200)
            {
                Destroy(gameObject);
            }
            else
            {
                col.GetComponent<Player>().playerPower += 20;
                Destroy(gameObject);
            }
        }
        if (col.tag == "Player" && gameObject.tag == "RedOrb")
        {
            if (col.GetComponent<Player>().playerHealth == 200)
            {
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
                col.GetComponent<Player>().playerHealth += 20;
            }
        }*/
    }
	void Start ()
    {
        speed = 10f;
        attractRange = 5f;
        player = GameObject.FindGameObjectWithTag("Player");
	}
	void Update ()
    {
        float step = speed * Time.deltaTime;
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if(distanceToPlayer<=attractRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
        }
	}
}
