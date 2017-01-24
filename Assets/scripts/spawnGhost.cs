using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class spawnGhost : MonoBehaviour {
    public GameObject ghost1;
    public GameObject ghost2;
    public GameObject ghost3;
    public GameObject ghost4;
    public GameObject ghost5;
    public GameObject ghost6;
    public GameObject ghost7;
    public GameObject ghost8;
    public GameObject ghost9;
    public GameObject love;
    public int spawnIntervals = 5;
    public AudioClip slowBeat;
    public AudioClip fastBeat;
    public GameObject playButton;
    public GameObject pauseButton;

    // Use this for initialization
    void Start () {
    
		
	}
    public void returnMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void restartScene()
    {
        SceneManager.LoadScene("playerTest");
    }
    public void shutdownGame()
        {
        Application.Quit();
        }
    public void pauseGame()
    {
        Time.timeScale = 0;
        playButton.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(false);
    }
    public void resumeGame()
    {
        Time.timeScale = 1;
        playButton.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(true);
    }


	
	// Update is called once per frame
	void Update () {
        if (Time.time >= 0&&!ghost1.gameObject.activeSelf)
        {
            ghost1.gameObject.SetActive(true);
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = slowBeat;
            audio.Play();
           
           
        }
        if (Time.time >= spawnIntervals && !ghost2.gameObject.activeSelf)
        {
            ghost2.gameObject.SetActive(true);
        }
        if (Time.time >= spawnIntervals*2 && !ghost3.gameObject.activeSelf)
        {
            ghost3.gameObject.SetActive(true);
        }
        if (Time.time >= spawnIntervals * 3 && !ghost4.gameObject.activeSelf)
        {
            ghost4.gameObject.SetActive(true);
           
        }
        if (Time.time >= spawnIntervals * 4 && !ghost5.gameObject.activeSelf)
        {
            ghost5.gameObject.SetActive(true);
        }
        if (Time.time >= spawnIntervals *5 && !ghost6.gameObject.activeSelf)
        {
            ghost6.gameObject.SetActive(true);
        }
        if (Time.time >= spawnIntervals * 6 && !ghost7.gameObject.activeSelf)
        {
            ghost7.gameObject.SetActive(true);
        }
        if (Time.time >= spawnIntervals * 7 && !ghost8.gameObject.activeSelf)
        {
            ghost8.gameObject.SetActive(true);
        }
        if (Time.time >= spawnIntervals *8 && !ghost9.gameObject.activeSelf)
        {
            ghost9.gameObject.SetActive(true);
        }
        if (Time.time >= spawnIntervals * 9 && !love.gameObject.activeSelf)
        {
            love.gameObject.SetActive(true);
           
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = fastBeat;
            audio.Play();
            Debug.Log("fastBeat");
        }
       
    }
}
