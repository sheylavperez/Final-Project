using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWander : MonoBehaviour
{

	public float moveSpeed;

	private Rigidbody rb;

	public bool isWander;

	public float WanderTime;

	public float WaitTime;

	private float wanderCounter;

	private float waitCounter;

	private int walkDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        waitCounter = WaitTime;

        wanderCounter = WanderTime;

        ChooseDirection();
    }

    // Update is called once per frame
    void Update()
    {
        if (isWander == true)
        {
        	wanderCounter -= Time.deltaTime;

        	switch (walkDirection)
        	{
        		case 0:
        		rb.velocity = new Vector2(0,moveSpeed);
        		break;

        		case 1:
        		rb.velocity = new Vector2(moveSpeed, 0);
        		break;

        		case 2:
        		rb.velocity = new Vector2(0, -moveSpeed);
        		break;

        		case 3:
        		rb.velocity = new Vector2(-moveSpeed,0);
        		break;
        	}

        	if (wanderCounter < 0)
        	{
        		isWander = false;
        		waitCounter = WaitTime;
        	}
        }
        else
        {
        	waitCounter -= Time.deltaTime;

        	rb.velocity = Vector2.zero;
        	if(waitCounter < 0)
        	{
        		ChooseDirection();
        	}
        }
    }


    public void ChooseDirection()
    {
    	walkDirection = Random.Range(0,4);

    	isWander = true;
    	wanderCounter = WanderTime;
    }
}
