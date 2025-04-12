using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rb;
    [SerializeField] protected float moveSpeed = 10f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
