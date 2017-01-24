using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepWaves : MonoBehaviour {
    private float createdTime;
    private float createdTimeAlpha;
    public float scaleSlower = 6f;

    // Use this for initialization
    void Start () {
        createdTime = Time.time;
        createdTimeAlpha = Time.time;

    }
	
	// Update is called once per frame
	void Update () {
        float scaleFactor = (Time.time - createdTime) / scaleSlower;
        transform.localScale = new Vector3(scaleFactor, 0.02f, scaleFactor);
        Color colorAlpha = gameObject.GetComponent<Renderer>().material.color;
        if (createdTimeAlpha + 0.05f <= Time.time)
        {
            colorAlpha.a -= 0.05f;
            gameObject.GetComponent<Renderer>().material.color = colorAlpha;
            createdTimeAlpha = Time.time;
        }

        if (Time.time >= createdTime + 3)
        {
            Destroy(gameObject);
        }
		
	}
}
