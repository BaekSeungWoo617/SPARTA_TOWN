using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    TopDownController controller;
    Rigidbody2D movementRigidbody;
    private Vector2 movementDirection = Vector2.zero;
    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        controller.OnMoveEvent += Move;
    }
    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }
    void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }
}
