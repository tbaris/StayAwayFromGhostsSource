using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class senseGhostDist : MonoBehaviour {

    public GameObject[] ghosts;
    float distanceGhost;
    public GameObject king;
    public GameObject player;
    private float flashTime;
    public float dista;
    private List<float> distances;

    // Use this for initialization
    void Start () {

        findGhosts();

    }
    void findGhosts()
    {
        ghosts = GameObject.FindGameObjectsWithTag("ghost");
       
    }
	// Update is called once per frame
	void Update () {
       foreach (GameObject ghost in ghosts)
        {
            distanceGhost = Vector3.Distance(ghost.transform.position, player.transform.position);

        }
        /* float ara = 0;
        
        foreach (GameObject ghost in ghosts)
        {
            if (ara == 0)
            {
                distanceGhost = Vector3.Distance(ghost.transform.position, player.transform.position);
                ara = distanceGhost;
                king = ghost;
            }
            else
            {
                distanceGhost = Vector3.Distance(ghost.transform.position, player.transform.position);
                if (distanceGhost < ara)
                {
                    dista = distanceGhost;
                    ara = distanceGhost;
                    king = ghost;
                }
            }
        }

        if (flashTime + dista == Time.time && gameObject.GetComponent<Renderer>().enabled)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            flashTime = Time.time;
        }
        if (flashTime + dista == Time.time && !gameObject.GetComponent<Renderer>().enabled)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
            flashTime = Time.time;
        }*/


    }
}
