using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

	//Let's add a variable to control the speed of the mouse
	public float mouseSensitivity = 100f;
	//we need a reference to the FirstPersonPlayer object
	//inside the code so that we can control its rotation
	public Transform playerBody;

	//now we'll add a variable that will help us with the
	//up and down camera rotation
	float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //we're gonna add things so that our update function can gather
        //some input data from our mouse

    	//"Mouse X" is a preprogrammed thing inside unity that let's you
    	//get data from the mouse about its movement in the X axis
    	//don't forget to set it up in project settings before calling it

    	//also we're controlling the speed of the mouse by multiplying it
    	//with the mouseSensitivity 
    	//and to make sure the rotation works independent of our current
    	//framerate (since we're using the update function)
    	//we'll also multiply it with the DeltaTime function
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        //we'll do the same for the Y axis
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

		 //now here's what we're doing for the up and down movement
        //of the camera
        //so every frame we're going to decrease our xRotation
        //based on mouse Y
        xRotation -= mouseY;

        //now here we're doing the Clamping
        //this tells them inside Clamp that 
        //Clamp(the value we want to clamp, minimum value, maximum value)
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //and with this we make the rotation happen.
        //the Euler has (X,Y,Z) values inside it
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);


        //now here we can control the FirstPersonPlayer roation
        //vector3.up = the Y axis
        playerBody.Rotate(Vector3.up * mouseX);

       
    }
}
