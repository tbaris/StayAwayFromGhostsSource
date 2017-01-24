using UnityEngine;
using System.Collections;

public class Overdo : MonoBehaviour {
    public GameObject target;
    UnityEngine.AI.NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination(target.transform.position);
    }
	
	// Update is called once per frame
	void Update () {
        playerController pControll = target.gameObject.GetComponent<playerController>();
        if (pControll.isGameOver || pControll.Winned)
        {
            stop();
        }else
        {
            follow();
        }
	
	}
    void stop() 
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination(transform.position);
    }
    void follow()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination(target.transform.position);
    }
}
