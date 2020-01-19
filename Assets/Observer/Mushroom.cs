using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    // Start is called before the first frame update
    public bool activated = false;
    private float time = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* 
        if (!activated)
        {
            time = Time.time + 10;
        }
        if(time != 0 && Time.time > time)
        {
            activated = true;
            Debug.Log("restored");
            time = 0;
        }
        */
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("activated");
        if (collision.gameObject.tag == "Player")
        {
            activated = true;
            Destroy(gameObject);
            Debug.Log("activated");
        }

    }
}
