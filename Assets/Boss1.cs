using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    public Transform player;
    public Mushroom mushroom1;
    public Mushroom mushroom2;
    public float timeBetweenAttacks;
    public float attackTime;
    public int health;

    public GameObject projectile;
    public Transform[] shotPoints;

    private float rotation=1;

    public bool disableShield = false;
    private int lives = 1;

    public int lol;

    void Start()
    {
        lol = 0;
        disableShield = false;
    }

    void Update()
    {
        //Debug.Log(disableShield);
        //transform.Rotate(0, 0, rotation);
        
        if (Time.time > attackTime)
            {
                attackTime = Time.time + timeBetweenAttacks;
                Shoot();
            }

        shotPoints[0].Rotate(0,0,rotation);
        shotPoints[1].Rotate(0, 0, rotation);
        if (lol >= health)
        {

            disableShield = true;
            Debug.Log(disableShield) ;
        }
        //Debug.Log("hfjfjhgjhgjhgjh   " + disableShield);
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && disableShield)
        {
            Debug.Log("boss died");

            lives--;
            disableShield = true;
        }
        if (lives == 0)
        {
            Destroy(gameObject);

        }
    }
}

