﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoidDeath : MonoBehaviour
{
    private void OnTriggerEnter (Collider col)
    
    {
    	if (col.gameObject.tag == "Player")
    	
    	{
    		SceneManager.LoadScene("TheEnd");
    	}
    	else
    	{
    		Debug.Log("Contact!");
    	}
    }
}
