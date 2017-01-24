using UnityEngine;
using System.Collections;

public class Sensor : MonoBehaviour {

    public GameObject[] ghost;
    public GameObject king;
    public float ghostdis;
    float ara = 0;
    public float ghostdis2;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        ghost = GameObject.FindGameObjectsWithTag("ghost");

        foreach (GameObject fds in ghost)
        {
            if (ara == 0)
            {
                ghostdis = Vector3.Magnitude(fds.transform.position - this.transform.position);
                ara = ghostdis;
                king = fds;
            }
            else
            {
                ghostdis = Vector3.Distance(fds.transform.position, this.transform.position);
                if (ghostdis < ara)
                {
                    ara = ghostdis;
                    king = fds;
                }
            }
            ghostdis2 = Mathf.Abs( Vector3.Magnitude(king.transform.position - this.transform.position));

        }

        ara = 0;


       


    }


}
