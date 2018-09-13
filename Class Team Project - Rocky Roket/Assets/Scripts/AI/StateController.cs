//zackery welk

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour
{
    public State currentState;
    public State remainState;
    public NavMeshAgent navMeshAgent;
    public Transform Target;
    public GameObject bulletSpawn;

    void Awake ()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        //bulletSpawn = GameObject.FindGameObjectWithTag("BulletSpawn");
    }
	
	// Update is called once per frame
	void Update () {
        currentState.UpdateState(this);
	}

    public void TransitionToState(State nextState)
    {
        //if the next state isnt the current one then change to the new state
        if(nextState != remainState)
        {
            currentState = nextState;
        }
    }

}
