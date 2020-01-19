using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Vector2 mousePressed;
    public float maxPower;
    public float maxRadius;

    private Rigidbody2D rb;
    private Vector2 movement;

    public LineRenderer line;
    public float laserWidth = 0.1f;

    public Transform startPos;

    private int dashes;

    public Material mat;

    public int health;

    void Start()
    {
        dashes = 2;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        rb.gravityScale = 1;
        if (Input.GetMouseButton(0) && dashes > 0) {
            line.enabled = true;
            //startPos.position - new Vector3(mousePressed.x, mousePressed.y, 0) + new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0) 
            Vector3 endPoint = startPos.position - new Vector3(mousePressed.x, mousePressed.y, 0) + new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            endPoint /= 80;
            Vector3[] initLaserPositions = new Vector3[2] { Vector3.zero, endPoint};
            line.SetPositions(initLaserPositions);
            line.SetWidth(laserWidth, laserWidth);


            rb.gravityScale = 0;
            rb.velocity = rb.velocity * new Vector2(0.5f, 0.5f) * Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0))
        {
            mousePressed = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }

        if (Input.GetMouseButtonUp(0) && dashes > 0)
        {
            line.enabled = false;
            Vector2 mouseReleased = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Push(mouseReleased);
            dashes--;
        }
    }
    

    private void Push(Vector2 mouseReleased)
    {
        Vector2 deltaVector = (mouseReleased - mousePressed);
        float speed = deltaVector.magnitude > maxRadius ? maxRadius : deltaVector.magnitude;
        float scale = speed / maxRadius * maxPower;
        deltaVector = deltaVector * new Vector2(scale, scale);
        rb.AddForce(deltaVector, ForceMode2D.Force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            dashes = 2;
        }
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
            Destroy(this.gameObject);
    }
}
