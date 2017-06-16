using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour {

    public GameObject ball;


	
	// Update is called once per frame
	void Update () {

        transform.rotation.Set(ball.transform.forward.x, 0, 0, 0);

	}
}
