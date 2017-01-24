using UnityEngine;
using System.Collections;

public class AI_Ghost : MonoBehaviour
{

    public GameObject[] loll;
    public GameObject[] loll2;
    public GameObject player;
    float distanceToTargetl;
    public GameObject kingl;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float ara = 0;
        float ara2 = 0;
        loll = GameObject.FindGameObjectsWithTag("blue");


    int count = 0;

        foreach (GameObject lolls in loll)
        {
            count = count + 1;
            if (ara == 0)
            {
                distanceToTargetl = Vector3.Distance(lolls.transform.position, player.transform.position);
                ara = distanceToTargetl;
                kingl = lolls;
            }
            else
            {
                distanceToTargetl = Vector3.Distance(lolls.transform.position, player.transform.position);
                if (distanceToTargetl < ara)
                {
                    ara = distanceToTargetl;
                    kingl = lolls;
                }
            }
        }

        if (count == 0)
        {
            count = count = 1;

            foreach (GameObject lolls in loll2)
            {
                if (ara2 == 0)
                {
                    ara2 = Vector3.Distance(lolls.transform.position, player.transform.position);
                    ara2 = distanceToTargetl;
                    kingl = lolls;
                }
                else
                {
                    distanceToTargetl = Vector3.Distance(lolls.transform.position, player.transform.position);
                    if (distanceToTargetl < ara2)
                    {
                        ara2 = distanceToTargetl;
                        kingl = lolls;
                    }
                }

            }
        }

        if (kingl.name == "sol")
        {
            //rigth is left so left is right you get it??
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        if (kingl.name == "sag")
        {
            //rigth is left so left is right you get it??
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (kingl.name == "ust")
        {
            transform.Translate(Vector3.back * Time.deltaTime);
        }
        if (kingl.name == "alt")
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if (kingl.name == "NE")
        {
            transform.Translate(Vector3.back * Time.deltaTime);
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (kingl.name == "NW")
        {
            transform.Translate(Vector3.back * Time.deltaTime);
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        if (kingl.name == "SW")
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        if (kingl.name == "SE")
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            transform.Translate(Vector3.left * Time.deltaTime);
        }

    }
}