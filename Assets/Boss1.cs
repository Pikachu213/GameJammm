using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    public Transform player;

    public float timeBetweenAttacks;
    public float attackTime;
    public int health;

    public GameObject projectile;
    public Transform[] shotPoints;

    private float rotation=1;


    void Start()
    {
       
    }

    void Update()
    {
        //transform.Rotate(0, 0, rotation);
        
        if (Time.time > attackTime)
            {
                attackTime = Time.time + timeBetweenAttacks;
                Shoot();
            }

        shotPoints[0].Rotate(0,0,rotation);
        shotPoints[1].Rotate(0, 0, rotation);
    }

    void Shoot() {
            Instantiate(projectile, shotPoints[0].position, shotPoints[0].rotation);
            Instantiate(projectile, shotPoints[1].position, shotPoints[1].rotation);
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
            Destroy(this.gameObject);
    }
}

