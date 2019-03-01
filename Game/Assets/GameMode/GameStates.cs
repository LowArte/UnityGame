using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStates : MonoBehaviour
{
    public SpawnEnemies SpawnEnemies;

    public Text text;

    private int seconds = 0;
    private int minuts = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Timer()
    {
        while(true)
        {
            seconds++;
            if (seconds == 60)
            {
                minuts++;
                seconds = 0;
            }
            yield return new WaitForSeconds(1);
            text.text = minuts + " : " + seconds;
        }
    }
}
