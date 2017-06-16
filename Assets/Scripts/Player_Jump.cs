using UnityEngine;
using System.Collections;

public class Player_Jump : MonoBehaviour
{

    public float jumpForce = 300.0f;
    public bool doubleJump = false;

    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public bool grounded = false;
    public LayerMask whatIsGround;

    void FixedUpdate()
    {
        bool jump = Input.GetButtonDown("Jump");

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        if (grounded) doubleJump = false;

        if (jump && (grounded || !doubleJump))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpForce);
            if (!doubleJump && !grounded) doubleJump = true;
        }
    }
}
