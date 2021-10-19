using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chaser : MonoBehaviour
{
    private bool chase;
    private Vector3 chasePoint;
    public NavMeshAgent navMeshAgent;

    private void Start()
    {
        chase = false;
    }

    private void Update()
    {
        if (chase)
        {
            navMeshAgent.SetDestination(chasePoint);
            chase = (transform.position == chasePoint);
        }
    }

    public void followPoint(Vector3 posn)
    {
        chase = true;
        chasePoint = new Vector3(posn.x, 0f, posn.z);
    }
}
