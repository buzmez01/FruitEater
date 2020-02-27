using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	private float speed = 5f;
    private float direction;

    private Rigidbody2D myBody;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }
     
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 vel = myBody.velocity;
        direction = Input.GetAxis("Horizontal");
        if (direction < 0)
        {
            vel.x = -1f * speed;
        }
        if (direction > 0)
        {
            vel.x = 1f * speed;
        }
        if(direction == 0f)
        {
            vel.x = 0f;
        }

        //Debug.Log(Mathf.Round(Input.GetAxis("Horizontal")));
        //vel.x = Mathf.Round(Input.GetAxis("Horizontal")) * speed;
        //vel.x = Input.GetAxis("Horizontal") * speed;
        myBody.velocity = vel;
    }

}
