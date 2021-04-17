using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this is for the AI
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{      
    //first we give our enemy some health
    public float health = 30f;

    //here we give an enemy value to our enemy
    public int Points = 1;

    //also here we call our devil model
    //that will appear when the angel "Dies"
    public GameObject lilDevil;

    //here are the things our enemy AI will use
    //to follow the player
    //public NavMeshAgent ourEnemy;
    //public Transform Player; //(so it knows the player's position)

    //void Update()
    //{
    	//ourEnemy.SetDestination(Player.position);
   // }




    //now we need a function that will damage our target
    //we're giving it the parameter of "amount"
    //so that we can dictate how much damage it gets
    public void TakeDamage(float amount)
    {
 //we're substracting the mount of damage from our health
 //the amount will be equal to the damage caused from our gun
    	health -= amount;
    	//when the health reaches 0,
    	//then our enemy dies
    	if (health <= 0f)
    	{
    		//we create a death function
    		Die();
    	}
    }

    //and here we define the death function

    void Die()
    {
        //here we add a point
        PointsScore.scoreValue += Points;
        //Here we'll transform our angel into a devil by instantiating
        //our devil model
        Instantiate(lilDevil,transform.position,transform.rotation);
        //here we'll destroy the object (our angel)
    	Destroy(gameObject);
    }
}
