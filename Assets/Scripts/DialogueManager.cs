﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{

    private Queue<string> sentences; //Fifo first in first out

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        
    }

    // Update is called once per frame
   
}
