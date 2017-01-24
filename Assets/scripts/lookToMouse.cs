using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookToMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 lookAt = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, (transform.position - Camera.main.transform.position).magnitude));
        lookAt.y = transform.position.y;  // Set it to the players height to avoid any non-y rotations
        transform.LookAt(lookAt);
    }
}
