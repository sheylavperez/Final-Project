using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalScore : MonoBehaviour
{
	private static int finalScore = PointsScore.scoreValue;

	[SerializeField] TextMeshProUGUI endScore;

    // Start is called before the first frame update
    //void Start()
    void Start()
    {
    	//We do this so the Score resets to 0, and then it grabs the new
    	//scoreValue made after we played again
    	finalScore = 0;
    	finalScore = PointsScore.scoreValue;



       endScore = GetComponent<TextMeshProUGUI>();
       endScore.text = "TOTAL TROOPS: " + finalScore;
    }

}
