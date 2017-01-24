using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {

    
    public GameObject letter;
    public GameObject beginBack;
    public GameObject beginButton;


    public void runGame()
    {
        SceneManager.LoadScene("playerTest");
    }
    public void skipLetter()
    {
        letter.gameObject.SetActive(false);
        beginBack.gameObject.SetActive(true);
        beginButton.gameObject.SetActive(true);
    }

}
