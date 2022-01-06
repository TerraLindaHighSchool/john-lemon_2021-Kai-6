using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    Animator m_Animator;
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;

    int m_CurrentWaypointIndex;

    void Start ()
    {
	m_Animator = GetComponent<Animator> ();
        navMeshAgent.destination = (waypoints[1].position);
    }

    void Update ()
    {
        if(navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex+1) % waypoints.Length;
            navMeshAgent.destination = waypoints[m_CurrentWaypointIndex].position;
        } 
        else
        {
            return;
        }
    }
}
