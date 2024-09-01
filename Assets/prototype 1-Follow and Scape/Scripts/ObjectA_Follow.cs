using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// using NavmeshAgent ObjectA should go follow object B.
/// </summary>
public class ObjectA_Follow : MonoBehaviour
{
    [SerializeField] NavMeshAgent navMeshAgent;

    [SerializeField] Transform ObjectB;


    void Update()
    {
        navMeshAgent.SetDestination(ObjectB.position);
    }
}
