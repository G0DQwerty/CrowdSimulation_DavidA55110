using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour {

    GameObject [] goalcations;
    NavMeshAgent agent;
    Animator anim;

    void Start() {

        agent = GetComponent<NavMeshAgent>();
        goalcations = GameObject.FindGameObjectsWithTag("Goal");
        int i = Random.Range(0, goalcations.Length);
        agent.SetDestination(goalcations[i].transform.position);
        anim = GetComponent <Animator>();
        anim.SetTrigger("isWalking");
        anim.SetFloat("wOffset",Random.Range(0.0f, 1.0f));
        float sm = Random.Range(0.5f, 2.0f);
        anim.SetFloat("speedMult",sm);
        agent.speed *= sm;
    }


    void Update() 
    {
        if (agent.remainingDistance < 1)
        {
            int i = Random.Range(0,goalcations.Length);
            agent.SetDestination(goalcations[i].transform.position);
        }
    }
}