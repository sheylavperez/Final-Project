using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WanderingAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask theGround;
    //patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    private void Awake()
    {
    	agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
    	if (player != null)
    	{
    		Patroling();
    	}
    }
    private void Patroling()
    {
    	if (!walkPointSet)
    	{
    		SearchWalkPoint();
    	}
    	else if (walkPointSet)
    	{
    		agent.SetDestination(walkPoint);
    	}
    	Vector3 distanceToWalkPoint = transform.position - walkPoint;
    	//walkpoint reached
    	if(distanceToWalkPoint.magnitude <1f)
    	{
    		walkPointSet = false;
    	}
    }
    private void SearchWalkPoint()
    {
    	//calculate random point in range
    	float randomZ = Random.Range(-walkPointRange, walkPointRange);
    	float randomX = Random.Range(-walkPointRange, walkPointRange);

    	walkPoint = new Vector3(transform.position.x + randomX, 
    		transform.position.y, transform.position.z + randomZ);

    	if(Physics.Raycast(walkPoint,-transform.up,2f,theGround))

    	walkPointSet = true;
    }
}
