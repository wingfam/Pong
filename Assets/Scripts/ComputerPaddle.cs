using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0f) {
            if (ball.position.y > transform.position.y) {
                rb.AddForce(Vector2.up * moveSpeed);
            } else if (ball.position.y < transform.position.y) {
                rb.AddForce(Vector2.down * moveSpeed);
            }
        }
        else {
            if (transform.position.y > 0f) {
                rb.AddForce(Vector2.down * moveSpeed);
            } else if (transform.position.y < 0f) {
                rb.AddForce(Vector2.up * moveSpeed);
            }
        }
    }
}
