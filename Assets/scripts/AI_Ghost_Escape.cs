using UnityEngine;
using System.Collections;

public class AI_Ghost_Escape : MonoBehaviour
{

    public GameObject[] lol;
    public GameObject[] lol2;
    public GameObject player;
    float distanceToTarget;
    public GameObject king;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float ara = 0;
        float ara2 = 0;
        lol = GameObject.FindGameObjectsWithTag("blue2");


        int count = 0;

        foreach (GameObject lols in lol)
        {
            count = count + 1;
            if (ara == 0)
            {
                distanceToTarget = Vector3.Distance(lols.transform.position, player.transform.position);
                ara = distanceToTarget;
                king = lols;
            }
            else
            {
                distanceToTarget = Vector3.Distance(lols.transform.position, player.transform.position);
                if (distanceToTarget > ara)
                {
                    ara = distanceToTarget;
                    king = lols;
                }
            }
        }

        if (count == 0)
        {
            count = count = 1;

            foreach (GameObject lols in lol2)
            {
                if (ara2 == 0)
                {
                    ara2 = Vector3.Distance(lols.transform.position, player.transform.position);
                    ara2 = distanceToTarget;
                    king = lols;
                }
                else
                {
                    distanceToTarget = Vector3.Distance(lols.transform.position, player.transform.position);
                    if (distanceToTarget < ara2)
                    {
                        ara2 = distanceToTarget;
                        king = lols;
                    }
                }

            }
        }

        if (king.name == "sol2")
        {
            //rigth is left so left is right you get it??
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        if (king.name == "sag2")
        {
            //rigth is left so left is right you get it??
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (king.name == "ust2")
        {
            transform.Translate(Vector3.back * Time.deltaTime);
        }
        if (king.name == "alt2")
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if (king.name == "NE2")
        {
            transform.Translate(Vector3.back * Time.deltaTime);
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (king.name == "NW2")
        {
            transform.Translate(Vector3.back * Time.deltaTime);
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        if (king.name == "SW2")
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        if (king.name == "SE2")
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            transform.Translate(Vector3.left * Time.deltaTime);
        }

    }
}
