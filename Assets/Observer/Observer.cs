using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    // Start is called before the first frame update
    public Mushroom mushroom1;
    public Mushroom mushroom2;
    public Boss1 boss;

    void Start()
    {
        Debug.Log("started");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("sadsa   "+boss.disableShield);
        if (!mushroom1.activated && !mushroom2.activated)
        {

            boss.disableShield = true;
            Debug.Log(boss.disableShield);
        }
    }
}
