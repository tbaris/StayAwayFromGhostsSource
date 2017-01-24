using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmRadar : MonoBehaviour {
    public GameObject emWave;
    private float lastEmWave = 0;
    public GameObject emCharge1;
    public GameObject emCharge2;
    public GameObject emCharge3;
    // Use this for initialization
    void Start () {

    }
    void shootEM()
    {
        if (lastEmWave <= Time.time - 3f)
        {
            Vector3 lookAt = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, (transform.position - Camera.main.transform.position).magnitude));
            lookAt.y = transform.position.y;  // Set it to the players height to avoid any non-y rotations
            transform.LookAt(lookAt);

            GameObject stepWaves = Instantiate(emWave, transform.position, transform.rotation);
            lastEmWave = Time.time;
            emCharge1.gameObject.SetActive(false);
            emCharge2.gameObject.SetActive(false);
            emCharge3.gameObject.SetActive(false);
        }
    }
	// Update is called once per frame
	void Update () {
        if (lastEmWave<= Time.time -1f)
        {
            emCharge1.gameObject.SetActive(true);
        }
        if (lastEmWave <= Time.time - 2f)
        {
            emCharge2.gameObject.SetActive(true);
        }
        if (lastEmWave <= Time.time - 3f)
        {
            emCharge3.gameObject.SetActive(true);
        }
        if (Input.GetMouseButtonDown(1))
        
        {
            shootEM();
        }
		
	}
}
