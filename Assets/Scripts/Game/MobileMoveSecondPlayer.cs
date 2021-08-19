using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MobileMoveSecondPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirY;
    public float moveSpeed = 8f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        dirY = CrossPlatformInputManager.GetAxis("Vertical2") * moveSpeed;
        // rb.velocity = new Vector2(0, dirx);
        rb.AddForce(new Vector2(0, dirY));
    }
}
