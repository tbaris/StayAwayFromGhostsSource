using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowGhost : MonoBehaviour {
    private float showedTime;
    public GameObject emWave;
    private float emBackTime;
    public bool isGameOver = false;
    public GameObject deathObject;
    private float deathTime;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "emwave")
        {
            showYourself();       
        }
        if (other.tag =="player" && !isGameOver)
        {
            GameObject stepWaves = Instantiate(deathObject, transform.position, transform.localRotation);
            playerController pControl = other.gameObject.GetComponent<playerController>();
            pControl.isGameOver = true;
            Debug.Log("you are dead");
        }
      
    }
    // Use this for initialization
    void Start () {
		
	}
    void showYourself()
    {
        Color colorAlpha = gameObject.GetComponent<Renderer>().material.color;
        colorAlpha.a = 0.6f;
        gameObject.GetComponent<Renderer>().material.color = colorAlpha;
        showedTime = Time.time;
        if (emBackTime + 3 <= Time.time)
        {
            GameObject stepWaves = Instantiate(emWave, transform.position, transform.localRotation);
            emBackTime = Time.time;
        }


    }
	
	// Update is called once per frame
	void Update () {

        Color colorAlpha = gameObject.GetComponent<Renderer>().material.color;
        if (showedTime + 0.1f <= Time.time)
        {
            colorAlpha.a -= 0.05f;
            gameObject.GetComponent<Renderer>().material.color = colorAlpha;
            showedTime = Time.time;
        }
        if(isGameOver && deathTime + 2 >= Time.time)
        {
         //   SceneManager.LoadScene
        }
    }
}
