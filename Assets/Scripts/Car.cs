using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    float Speed = 1f;
    public float minSpeed = 8f;
    public float maxSpeed = 12f;

    void Start()
    {
      Speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate()
    {
      Vector2 forward = new Vector2(transform.right.x, transform.right.y); // to car move wherever it want(not in single Direction) and convert vector3 to vector 2 beacuse we are in 2D mode!
      rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * Speed);
    }
}
