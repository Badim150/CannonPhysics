using UnityEngine;
using System.Collections;

public class Bullet_Fire : MonoBehaviour {

    public float bulletForce = 750.0f;

    void OnTriggerEnter2D (Collider2D target)
    {
        if (target.gameObject.tag == "FirePoint") GetComponent<Rigidbody2D>().AddForce(transform.right * bulletForce);
    }
}
