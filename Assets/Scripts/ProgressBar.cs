using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour {

    public float progress = 0;
    public Vector2 position = new Vector2(20, 40);
    public Vector2 size = new Vector2(200, 20);
    public Texture2D progressEmptyImage;
    public Texture2D progressFullImage;
    public float run = 0.01f;
    public float speed = 0;
    public bool check = false;


    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(position.x, position.y, size.x, size.y), progressEmptyImage);
        GUI.DrawTexture(new Rect(position.x, position.y, size.x*Mathf.Clamp01(progress), size.y), progressFullImage);
    }

    private void Update()
    {
      //  StartCoroutine(delay());
    }

    IEnumerator delay()
    {
        check = true;
        progress += run;
        yield return new WaitForSeconds(speed);
        check = false;
    }
}
