using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;

    public float speed;

    public float minX = -10f;
    public float maxX = 1f;
    public float minY = 10.5f;
    public float maxY = -1.4f;

    private Vector3 fail;

    // Start is called before the first frame update
    void Start()
    {
        //fail = new Vector3(0,0,-10);
        //transform.position = playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform != null)
        {
            //float clampedX = Mathf.Clamp(playerTransform.position.x, minX, maxX);
            //float clampedY = Mathf.Clamp(playerTransform.position.y, minY, maxY);

            //transform.position = Vector2.Lerp(transform.position, new Vector2(clampedX, clampedY), speed);
            transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -100.2f);
        }
    }
}
