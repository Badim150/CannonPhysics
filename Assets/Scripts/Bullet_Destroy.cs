using UnityEngine;
using System.Collections;

public class Bullet_Destroy : MonoBehaviour {

    public Transform bullet;
    public float colissionRadius = 0.4f;
    public bool collided = false;
    public LayerMask whatToCollideWith;

    void FixedUpdate ()
    {
        collided = Physics2D.OverlapCircle(bullet.position, colissionRadius, whatToCollideWith);

        if (collided) Destroy(gameObject);
        if (!GetComponent<Renderer>().isVisible) Destroy(gameObject);
    }
}
