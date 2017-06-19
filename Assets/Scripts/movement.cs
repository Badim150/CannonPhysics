using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement : MonoBehaviour
{

    [SerializeField] private BallLauncher launcher;

    public float speed = 50f;
    public float spacing = 100.0f;
    private Vector3 pos;
    

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.z = position.z + 5;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.z = position.z - 5;
            this.transform.position = position;
        }
    /*   if (Input.GetKeyDown(KeyCode.W))
        {
            launcher.h += 2;
        }
       if (Input.GetKeyDown(KeyCode.S))
        {
            launcher.h -= 2;
        }*/
    }
}