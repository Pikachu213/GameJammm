using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flooding : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    public float repeatTime;

    public Transform downPoint;
    public Transform upPoint;

    public GameObject water;
    public float speed;

    private bool isFlooding = true;
    void FixedUpdate()
    {

        if (isFlooding)
        {
            water.transform.Translate(speed * Vector3.up * Time.deltaTime, Space.World);
            if (water.transform.position.y > upPoint.position.y)
            {
                isFlooding = false;
            }
        }
        else
        {
            water.transform.Translate(speed * Vector3.down * Time.deltaTime, Space.World);
            if (water.transform.position.y < downPoint.position.y)
            {
                isFlooding = true;
            }

        }

    }


}
