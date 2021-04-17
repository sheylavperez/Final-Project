using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilFloat : MonoBehaviour
{
	public float FloatStrenght = 300f;
	Rigidbody rb;

    // Start is called before the first frame update
    void Awake()
    {
    	//you need to fetch the rigidbody first
    	rb = GetComponent<Rigidbody>();
    	StartCoroutine(Floating());
    	rb.velocity = new Vector3(0,FloatStrenght,0);
		    	    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Floating()
    {
    	yield return new WaitForSeconds(5);
    	rb.velocity = new Vector3(0,FloatStrenght,0);
    }
}
