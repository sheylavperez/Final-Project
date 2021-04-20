using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
	//when the timer ends
	float currentTime = 0f;
	//total timer
	float startingTime = 105f;

	Color red = Color.red;

	[SerializeField] TextMeshProUGUI countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }
    // Update is called once per frame
    void Update()
    {
        //decrease the time over by one each second
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("[" + "0.0" + "]");

        if (currentTime <= 0)
        {
        	currentTime = 0;
        	//SceneManager.LoadScene("TheEnd");
            SceneManager.LoadScene("WinLoseScenes");
        	Debug.Log("Game ended!");
        }
        if (currentTime <= 5)
    	{
    		countdownText.color = red;
    	}
        //Debug.Log(currentTime);
    }
}
