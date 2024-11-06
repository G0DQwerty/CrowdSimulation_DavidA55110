using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AiControl : MonoBehaviour
{
    public GameObject goal;
    NavMeshAgent actor;
    void Start()
    {
        actor = GetComponent<NavMeshAgent>();
        actor.SetDestination(goal.transform.position);
    }
    void Update()
    {

    }
}