using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float gravity = 0f;
    public Vector2 speed;
    // Update is called once per frame
    void Update()
    {
        gravity = Input.GetAxis("Vertical");
        Vector2 speed = new Vector2(1, 1);
        GetComponent<Rigidbody2D>().velocity = speed;
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().gravityScale = gravity;
    }
}
