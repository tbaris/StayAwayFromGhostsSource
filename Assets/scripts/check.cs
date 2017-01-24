using UnityEngine;
using System.Collections;

public class check : MonoBehaviour {

    public GameObject[] lol;
    public GameObject[] lol2;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update()
    {
        lol = GameObject.FindGameObjectsWithTag("blue");
        foreach (GameObject lols in lol)
        {
        }

    }
}
