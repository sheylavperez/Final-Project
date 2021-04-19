using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointsScore : MonoBehaviour
{
	public static int scoreValue = 0;

	[SerializeField] TextMeshProUGUI score;

    
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    
    void Update()
    {
        score.text = "Troops: " + scoreValue;
    }
}
