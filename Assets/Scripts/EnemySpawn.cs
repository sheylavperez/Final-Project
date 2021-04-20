using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int yPos;
    public int zPos;

    public int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyDrop());
    }


    IEnumerator enemyDrop()
    {
    	//while (enemyCount < 5)
    	while (enemyCount < 25)
    	{
    		//xPos = Random.Range(1,20);
    		//yPos = Random.Range(1,5);
    		//zPos = Random.Range(1,20);

    		xPos = Random.Range(1,50);
    		yPos = Random.Range(1,30);
    		zPos = Random.Range(1,200);

    		Instantiate(theEnemy, new Vector3(xPos,yPos,zPos), Quaternion.identity);
    		//wait time:
    		//the wait time is in seconds
    		yield return new WaitForSeconds(0.1f);

    		enemyCount += 1;
    	}
    }
    
}
