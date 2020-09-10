using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMove : MonoBehaviour
{
    Vector3 MousePosition;
    Rigidbody2D rb;
    Vector2 direction;
    public float MoveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (MousePosition - transform.position).normalized;
        rb.velocity = new Vector2(direction.x * MoveSpeed, direction.y * MoveSpeed);
        FaceMouse();
    }
    void FaceMouse()
    {
        Vector2 PointDirection = new Vector2(
            MousePosition.x - transform.position.x,
            MousePosition.y - transform.position.y);

        transform.up = PointDirection;
    }
}
