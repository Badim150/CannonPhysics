using UnityEngine;
using System.Collections;

public class Player_Move : MonoBehaviour
{
    public float walkSpeed = 10.0f;

    public bool facingRight = true;

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        if (move < 0) GetComponent<Rigidbody2D>().velocity = new Vector3(move * walkSpeed, GetComponent<Rigidbody2D>().velocity.y);
        if (move > 0) GetComponent<Rigidbody2D>().velocity = new Vector3(move * walkSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move < 0 && facingRight) Flip();
        if (move > 0 && !facingRight) Flip();
    }

    void Flip ()
    {
        facingRight = !facingRight;
        transform.Rotate(Vector3.up * 180);
    }
}
