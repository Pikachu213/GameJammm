using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    // Start is called before the first frame update
    public bool activated;
    private float time = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!activated)
        {
            time = Time.time + 10;
        }
        if(time != 0 && Time.time > time)
        {
            activated = true;
            time = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            activated = false;
    }
}
