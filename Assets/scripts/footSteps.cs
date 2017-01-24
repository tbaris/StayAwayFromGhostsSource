using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footSteps : MonoBehaviour {

     private Vector3 previous;
     public float velocity;
     public GameObject player;
     private float stepTime = 0f;
     private float stepX;
    public bool isForward = true;
    private bool audioPlaying;

     // Use this for initialization
     void Start () {

     }

    // Update is called once per frame
    void Update()
    {


        playerController playerScript = player.gameObject.GetComponent<playerController>();
        bool isMoved = playerScript.isMoving;
        if(isMoved)
        {
            gameObject.GetComponent<Animator>().StopPlayback();
            if (!audioPlaying)
            {
                audioPlaying = true;
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
            }
        }
        else
        {
            gameObject.GetComponent<Animator>().StartPlayback();
            AudioSource audio = GetComponent<AudioSource>();
            audioPlaying = false;
            audio.Stop();
        }


    }
}

