using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public float playerSpeed = 1;
    public bool isMoving = false;
    public GameObject stepWave;
    private float lastWave = 0;
    public Vector3 movement;
    public RigidbodyConstraints prevConstrainsts;
    public GameObject redFlasher;
    private float timeFlash;
    public GameObject walls;
    public bool isGameOver = false;
    public bool Winned = false;
    public GameObject dead;
    public GameObject win;
    private float rbResetTime;
   

    // Use this for initialization
    void Start () {
        prevConstrainsts = gameObject.GetComponent<Rigidbody>().constraints;
	}
	
	// Update is called once per frame
	void Update () {
       /* Vector3 lookAt = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, (transform.position - Camera.main.transform.position).magnitude));
        lookAt.y = transform.position.y;  // Set it to the players height to avoid any non-y rotations
        transform.LookAt(lookAt);*/
        
        if (isMoving)
        {

            steps();
        }
        flasher();
        winOrlose();
    }
    private void OnCollisionExit(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;

    }
    private void FixedUpdate()
    {
        move();
    }

    private void winOrlose()
    {
        if (isGameOver)
        {
            dead.gameObject.SetActive(true);
        }
        else if (Winned)
        {
            win.gameObject.SetActive(true);
        }
    }

    private void steps()
    {
        
        if (lastWave <= Time.time - 0.5f)
        {
            GameObject stepWaves = Instantiate(stepWave, transform.position, Quaternion.identity);
            lastWave = Time.time;
        }
    }

    private void move()
    {  
            float moveHorizontal = Input.GetAxisRaw("Horizontal");
            float moveVertical = Input.GetAxisRaw("Vertical");

            movement = new Vector3(moveHorizontal*1.4f, 0.0f, moveVertical);
            transform.rotation = Quaternion.LookRotation(movement);

     
        if (moveHorizontal > 0 || moveVertical > 0 || moveHorizontal < 0 || moveVertical < 0)
        {
            if (!isGameOver && !Winned)
            {
                isMoving = true;
                transform.Translate(movement.normalized * playerSpeed * Time.deltaTime, Space.World);
                transform.position = new Vector3(transform.position.x, 1.45f, transform.position.z);
                gameObject.GetComponent<Rigidbody>().constraints = prevConstrainsts;
            }
          /*  if (rbResetTime + 0.01f >= Time.time   )
            {
                gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
                rbResetTime = Time.time;
            }*/
        }
        if (moveVertical == 0 && moveHorizontal == 0)
        {
            isMoving = false;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
            rbResetTime = Time.time;
        }
   

        }
    void flasher()
    {
        
        Sensor sensor = gameObject.GetComponent<Sensor>();
        float ghostdistz = sensor.ghostdis2 / 20;
        
        if (!redFlasher.gameObject.activeSelf && timeFlash + ghostdistz <= Time.time)
        {
            redFlasher.gameObject.SetActive(true);
            timeFlash = Time.time;
            
        }
        if (redFlasher.gameObject.activeSelf && timeFlash + ghostdistz <= Time.time)
        {
            redFlasher.gameObject.SetActive(false);
            timeFlash = Time.time;
            
        }
    }
    
    void colorbeat()
    {

    }

}
