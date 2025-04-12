using UnityEngine;

public class PlayerController : Paddle
{
    private Vector2 moveDirection;

    void Update()
    {
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(0, moveY);
    }

    void FixedUpdate()
    {
        if (moveDirection.sqrMagnitude != 0) {
            rb.AddForce(moveDirection * moveSpeed);
        }   
    }
}
