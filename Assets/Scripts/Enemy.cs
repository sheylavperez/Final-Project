using System.Collections;
using System.Collections.Generic;
//you might need to delete the lines before this one^^
using UnityEngine;

public class Enemy : MonoBehaviour
{
       
    //this is gonna be a very simple script

    //first we give our enemy some health
    public float health = 20f;

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
    	//here we'll destroy the object
    	Destroy(gameObject);
    }
}
