using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

    void start()
    {
        this.tag = ("blue");
    }

    void OnTriggerStay(Collider col)
    {
        this.tag = "red";
    }
        
    void OnTriggerExit(Collider col)
    {
        this.tag = "blue";
    }
}
