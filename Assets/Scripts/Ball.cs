using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 5f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        ResetPosition();
    }

    void LaunchBall()
    {
        float randomX = Random.value < 0.5f ? -1f : 1f; // Randomly choose left or right
        float randomY = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : 
                                              Random.Range(0.5f, 1f); // Randomly choose up or down
        Vector2 direction = new Vector2(randomX, randomY).normalized;
        rb.AddForce(direction * speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            Vector2 direction = (transform.position - collision.transform.position).normalized;
            rb.AddForce(direction * speed);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Right Goal") || 
            collision.gameObject.CompareTag("Left Goal")) {
                transform.position = new Vector3(0,0,0);
                LaunchBall();
        }
    }

    public void AddForce(Vector2 force)
    {
        rb.AddForce(force);
    }

    public void ResetPosition()
    {
        rb.position = Vector3.zero;
        rb.velocity = Vector3.zero;
        LaunchBall();
    }
}
