using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endings : MonoBehaviour
{
    private static int endingDet = PointsScore.scoreValue;

	public GameObject tryScene;
    public GameObject lowScene;
    public GameObject highScene;

    public int tryScore;
    public int loseScore;
    public int winScore;

    void Start()
    {
    	//here to restart the Score when the player plays a second time
    	endingDet = 0;
    	endingDet = PointsScore.scoreValue;

     if (endingDet <= tryScore)
     {
     	tryScene.SetActive(true);
     }
     else if (endingDet > tryScore && endingDet <= winScore)
     {
     	lowScene.SetActive(true);
     }
     else if(endingDet >= winScore)
     {
     	highScene.SetActive(true);
     }

    }
}
