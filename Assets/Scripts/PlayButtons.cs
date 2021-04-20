using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//here to load scenes
using UnityEngine.SceneManagement;

public class PlayButtons : MonoBehaviour
{
    
    public void LoadScenes(string sceneName)
    {
    	SceneManager.LoadScene(sceneName);
    }
}
