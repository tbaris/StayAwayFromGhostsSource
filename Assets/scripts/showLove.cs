using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showLove : MonoBehaviour {

    private float showedTime = 0f;
    public GameObject heartWave;
    private float emBackTime;
    public bool isWin = false;
    public GameObject loveObject;
    private bool lowerAlpha = true;



    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "emwave")
        {
            showYourself();
        }
        if (other.tag == "player" && !isWin )
        {
            GameObject stepWaves = Instantiate(loveObject, transform.position, transform.localRotation);
            playerController pControl = other.gameObject.GetComponent<playerController>();
            pControl.Winned = true;
            isWin = true;
        }

    }
    // Use this for initialization
    void Start()
    {

    }
    void showYourself()
    {
     
       /* if (emBackTime + 3 <= Time.time)
        {
            GameObject stepWaves = Instantiate(heartWave, transform.position, transform.localRotation);
            emBackTime = Time.time;
        }*/


    }

    // Update is called once per frame
    void Update()
    {

        
        Color colorAlpha = gameObject.GetComponent<Renderer>().material.color;
        if(colorAlpha.a >=1f)
        {
            lowerAlpha = true;
        }
        if(colorAlpha.a <= 0.30f)
        {
            lowerAlpha = false;
        }
        if (showedTime + 0.2f <= Time.time&&!lowerAlpha)
        {
            colorAlpha.a += 0.05f;
            gameObject.GetComponent<Renderer>().material.color = colorAlpha;
            showedTime = Time.time;
        }
        if (showedTime + 0.2f <= Time.time && lowerAlpha)
        {
            colorAlpha.a -= 0.05f;
            gameObject.GetComponent<Renderer>().material.color = colorAlpha;
            showedTime = Time.time;
        }

    }
}
