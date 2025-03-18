using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int damage = 10;
    public Transform target;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.SetDestination(target.position);

        var distance = Vector3.Distance(transform.position, target.position);

        if (distance < 5)
        {
            agent.isStopped = true;
            target.GetComponent<Health>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
