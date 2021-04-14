using System.Collections;
using System.Collections.Generic;
//you might need to delete the lines before this one^^
using UnityEngine;

public class Gun : MonoBehaviour
{
    //make a variable you can adjust of the amount of damage you can do
    //with your gun
    public float damage = 10f;
    //a range for your bullets?
    public float range = 100f;

    //we're creating a reference to our camera
    //because we're Raycasting
    public Camera fpsCam;

    //here we're calling our particle system
    public ParticleSystem muzzleFlash;

    // Update is called once per frame
    void Update()
    {
        //to be able to shoot, we need some input from the player
        //here we'll check if the player is clicking "Fire1"
        //which is the preprogrammed button by unity
        //that means "mouse left click"
        if(Input.GetButtonDown("Fire1"))
        {
        	//here we will call our Shoot function
        	Shoot();
        }

    }

    //and here we will CREATE our Shoot function

    void Shoot()
    {
    	//we activate our particle system
    	muzzleFlash.Play();


    	//the variable raycastHit is where we'll store the info
    	//on what we're hitting with the ray
    	RaycastHit hit;

    	//here is the code what will make us shoot the ray
    	//Raycast is preprogrammed you just need to fill the () info
    	//according to different parameters you may want

    	//for this one, we want to shoot a ray from the 1) position of our camera,
    	//2) in the direction we're facing
    	//3) and we want to store the info inside our variable
    	//(out means it'll toss all that info in there)
    	//4) and input our range so that objects outside that range can't be hit
    	//these are all the parameters as read inside the "()"
    	if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
    	{
    		//first we get the info of the object we hit
    		//remember "hit" is our variable where the info is stored
    		Debug.Log(hit.transform.name);

    		//here we're referencing the Enemy script
    		//and storing that info inside a variable
    		//it's a variable type "Enemy" just like the script
    		Enemy enemy = hit.transform.GetComponent<Enemy>();

    		//but not everything we shoot at will be an Enemy
    		//so make a check to see if we found an Enemy component
    		//inside our target

    		if (enemy != null)
    		{
    			//we're making our damage = amount
    			enemy.TakeDamage(damage);
    			//this will make the enemy take damage
    		}
    	}

    }


}
