using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float speed = 50f;
    public float spacing = 100.0f;
    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.z = position.z + 5;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.z = position.z - 5;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.x = position.x + 5;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - 5;
            this.transform.position = position;
        }
    }
}