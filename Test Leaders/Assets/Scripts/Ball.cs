using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    private Vector2 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        direction = new Vector2(1, 1);
    } 

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x > 10 || transform.position.x < -10)
        {
            transform.position = new Vector2(0,0);
            // Update scoreboard here
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Paddle"))
        {
            direction.x *= -1;
        }
        else
        {
            direction.y *= -1;
        }
    }
}
