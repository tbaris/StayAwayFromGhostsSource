using UnityEngine;
using System.Collections;

public class Trigger2 : MonoBehaviour
{

    void start()
    {
        this.tag = ("blue2");

    }

    void OnTriggerStay(Collider col)
    {
        this.tag = "red2";
    }
    void OnTriggerExit(Collider col)
    {
        this.tag = "blue2";
    }
}