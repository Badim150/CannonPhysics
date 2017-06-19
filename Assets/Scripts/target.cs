using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class target : MonoBehaviour {


    Collider box;
    [SerializeField] private GameObject cannon;
    [SerializeField] private Text textUI;
    [SerializeField] private int points = 1;

    // Use this for initialization
    void Start () {
        box = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation.Set(cannon.transform.forward.x, 0, 0, 0);
    }

    private void OnTriggerEnter(Collider box)
    {
        print("score!");
        int score = Int32.Parse(textUI.text) + points;
        textUI.text = score.ToString();
    }

}
