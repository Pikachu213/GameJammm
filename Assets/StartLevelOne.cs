using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevelOne : MonoBehaviour
{
    // Start is called before the first frame update
    public tutotial_mob tumb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(tumb);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(tumb == null)
        {

        }
            
    }
}
