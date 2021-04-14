using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    //here we make a reference to our player object so we can
    //influence it from inside the script
    public CharacterController controller;

    //here we make a way for us to control the speed of the
    //player's movement
    public float speed = 12f;

    //here we're adding our velocity value
    Vector3 velocity;

    //and a value for gravity
    public float gravity = -9.81f;

    //let's use our Groundcheck
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    //we're creating a LayerMask so that we can control
    //the objects we check with the groundcheck
    public LayerMask groundMask;
    //and our ol' reliable Bool
    bool isGrounded;

    //our maximum jumping height
    public float jumpHeight = 3f;

    void Update()
    {
    	//we're gonna make a groundCheck by creating a sphere that will
    	//collide with physics and check if the player is touching the ground
    	//CheckSphere(position, using the groundDistance as radius of the sphere, and which layer mask its checking)
    	isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

    	if(isGrounded && velocity.y < 0)
    	{
    		//we would do this logically since we're on the ground and not moving
    		//however, since the boolean might register earlier
    		//velocity.y = 0f;

    		//then we use an even smaller value to make the check since
    		//it works better
    		velocity.y = -2f;
    	}


    	//let's get some input values going for horizontal/vertical movement
    	//this will make directions from where we can move
    	float x = Input.GetAxis("Horizontal");
    	float z = Input.GetAxis("Vertical");

    	//now using these values we'll create a vector3
    	//that we'll use to Move (as in, we're giving it direction and force)
    	//Vector3 move = new Vector3 (x, 0f, z);

    	//but using the above only gives us 1 direction
    	//we want to be able to turn around anc change direction to
    	//move forwards
    	//so we write this instead (that takes the direction the player
    	//is facing)
    	Vector3 move = transform.right * x + transform.forward * z;
    	//^^^ this way we can change directions according to the players input

    	//and here we tell the Player object how to move
    	//the function "Move" uses a vector3 with a motion
    	//therefore, putting our "move" inside will work
    	controller.Move(move * speed * Time.deltaTime);

    	//and here is where we do our jumping code
    	if (Input.GetButtonDown("Jump") && isGrounded)
    	{
    		velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    	}



    	//here we're making our fall thanks to gravity but in a 
    	//smoother way
    	//what we're basically doing here, is making a constant
    	//diagonal line going down
    	velocity.y += gravity * Time.deltaTime;

    	//and now to use that velocity in our movement
    	controller.Move(velocity * Time.deltaTime);

    }
}
