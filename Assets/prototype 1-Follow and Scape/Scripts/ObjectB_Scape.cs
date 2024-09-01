using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/// <summary>
///  using NavmeshAgent ObjectB should scape from objectA.
/// </summary>
public class ObjectB_Scape : MonoBehaviour
{
    [SerializeField] NavMeshAgent navMeshAgent;

    [SerializeField] Transform ObjectA;
    [SerializeField] float MaxRadius;

    private void Start()
    {
        InvokeRepeating("Scape", 0, 2);
    }

    [SerializeField] float DistanceCalculate;
    [SerializeField] float DistanceThreshold = 10;
    NavMeshHit hit;
    Vector3 randomPoint;
    void Scape()
    {
        DistanceCalculate = Vector3.Distance(ObjectA.position, transform.position);

        if (DistanceCalculate < DistanceThreshold)
        {
            //navMeshAgent.SetDestination(transform.position + transform.position - ObjectA.position);

            randomPoint = FindRandomPosInCircle(MaxRadius);

            if (NavMesh.SamplePosition(randomPoint, out hit, MaxRadius, NavMesh.AllAreas))
            {
                // If the random point is valid on the navmesh, perform actions here
                Debug.Log("Random Point Generated: " + hit.position);

                navMeshAgent.SetDestination(hit.position);
            }
            else
            {
                Debug.Log("Random Point is Invalid ");
            }
        }
        else
        {
            navMeshAgent.ResetPath(); // Stop Object B
        }
    }
    Vector3 RandomPos;
    private Vector3 FindRandomPosInCircle(float radius)
    {
        Vector2 randomPoint = Random.insideUnitCircle * radius;
        return new Vector3(randomPoint.x, 0, randomPoint.y) + transform.position;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(randomPoint, 2);
    }
}
