using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Paddle : Paddle
{
    public Vector2 Direction { get; private set; }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.Direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.Direction = Vector2.down;
        }
        else
        {
            this.Direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (this.Direction.sqrMagnitude != 0)
        {
            this.rigidbody.AddForce(this.Direction * this.speed);
        }
    }
}