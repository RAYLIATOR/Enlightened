using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody rb;
    public Light glow;
    public Animator enemyAs;
    GameObject target;
    float health;
    float MaxSpeed;
    float moveForce;
    bool spawn;
    float distToPlayer;
    float chaseRange;
    float attackRange;
    bool glowing;
    bool despawn;
    float attackRate;
    float nextTimeToAttack;
	void Start ()
    {
        enemyAs.SetTrigger("Roar");
        moveForce = 300f;
        MaxSpeed = 1f;
        rb = GetComponent<Rigidbody>();
        nextTimeToAttack = 0;
        attackRate = .5f;
        attackRange = 5f;
        despawn = false;
        glowing = true;
        chaseRange = 50f;
        target = GameObject.FindGameObjectWithTag("Player");
        spawn = true;
        health = 150f;
        MaxSpeed = 0.1f;
	}
	
	void Update ()
    {
        distToPlayer = Vector3.Distance(target.transform.position, transform.position);
        Spawn();
        Chase();
        if(!glowing)
        {
            glow.intensity -= 0.03f;
        }
        if(despawn)
        {
            GetComponent<BoxCollider>().isTrigger = true;
            transform.position += Vector3.down * 0.03f;
        }
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxSpeed);
    }
     //keys keys keys
    public void TakeDamage()
    {
        health -= 50;
        if(health<=0)
        {
            Die();
        }
        else
        {
            enemyAs.SetTrigger("Hit");
        }
    }

    void Die()
    {
        rb.isKinematic = true;
        glowing = false;
        rb.velocity = Vector3.zero;
        enemyAs.SetTrigger("Die");
        Invoke("Despawn", 2.3f);
        Destroy(gameObject, 8f);
    }

    void Attack()
    {
        enemyAs.SetTrigger("Attack");
        target.GetComponent<Player>().LoseHealth(10);
    }

    void Chase()
    {
        if(!spawn && distToPlayer <= chaseRange)
        {
            if (distToPlayer <= attackRange && Time.time >= nextTimeToAttack)
            {
                Attack();
                nextTimeToAttack = Time.time + 1 / attackRate;
            }
            else if(health > 0)
            {
                enemyAs.SetTrigger("Walk");
                transform.LookAt(target.transform);
                rb.AddForce(transform.forward * moveForce);
            }
        }
        else if (distToPlayer > chaseRange && !spawn)
        {
            enemyAs.SetTrigger("Idle");
        }
    }
    void Spawn()
    {
        if(transform.position.y<0 && !despawn)
        {
            spawn = true;
            transform.position += Vector3.up * 0.03f;
        }
        else
        {
            spawn = false;
            rb.useGravity = true;
        }
    }
    void Despawn()
    {
        despawn = true;
    }
}
