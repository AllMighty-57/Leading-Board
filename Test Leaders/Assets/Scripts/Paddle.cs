using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float moveVertical = Input.GetAxis("Vertical"); 
        rb.linearVelocity = new Vector3(0, moveVertical * speed, 0);
    }
}
