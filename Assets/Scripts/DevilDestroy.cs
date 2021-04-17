using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilDestroy : MonoBehaviour
{
    private void OnCollisionEnter (Collision col)
    {
    	if (col.gameObject.tag == "Player")
    	{
    		Debug.Log("PlayerTouch");
    	}
    	else if (col.gameObject.tag == "Angel")
    	{
    		Debug.Log("AngelTouch");	
    	}
    	else
    	{
    		Destroy(col.gameObject);
    	}
    }
}
