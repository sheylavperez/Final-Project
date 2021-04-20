using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endings : MonoBehaviour
{
    private static int endingDet = PointsScore.scoreValue;

    public GameObject lowScore;
    public GameObject highScore;

    public int loseScore;
    public int winScore;

    void Start()
    {
     if (endingDet <= loseScore)
     {
     	lowScore.SetActive(true);
     }
     else if (endingDet >= winScore)
     {
     	highScore.SetActive(true);
     }

    }
}
