using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThierdBoss : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player; 
    public float attackTime; // time before first attack
    public float timeBetweenAttacks;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > attackTime)
        {
            attackTime = Time.time + timeBetweenAttacks;
            Shoot();
        }

    }
    void Shoot()
    {
        startPos.position - new Vector3(mousePressed.x, mousePressed.y, 0) + new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)
        Vector3[] initLaserPositions = new Vector3[2] { Vector3.zero, startPos.position - new Vector3(mousePressed.x, mousePressed.y, 0) + new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0) };
        line.SetPositions(initLaserPositions);
        line.SetWidth(laserWidth, laserWidth);
    }
}
