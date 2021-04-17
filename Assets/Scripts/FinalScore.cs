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
    void Start()
    {
       endScore = GetComponent<TextMeshProUGUI>();
       endScore.text = "Total troops: " + finalScore;
    }

}
