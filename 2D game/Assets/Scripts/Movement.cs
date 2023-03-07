using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D body;
    public float speed = 5f;
    Vector2 movement;

    // Start is called before the first frame update
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        movement.x =  Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        //Sets velocity every Fixed Timestep
        body.MovePosition(body.position + movement * speed * Time.fixedDeltaTime);

       

        


    }
}
