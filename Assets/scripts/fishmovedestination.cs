using UnityEngine;
using System;
public class fishmovedestination : MonoBehaviour
{
    //starting time to change, I planned to edit it but didn't get the time
    private float changeTime = 7.0f;
    //minimum time it could change, low for quick fish and high for slow fish
    public float howLongmin = 1.0f;
    //maximum, low for quick fish and high for slow fish
    public float howLongmax = 7.0f;
    //the distance it travels, eg does the fish travel it big lengths or little twitches
    public float changeDistance = 4;
    void Update()
    {
        //time countsa down until new destination set
        changeTime -= Time.deltaTime;

        if (changeTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        //new destination 
        this.transform.position += new Vector3(UnityEngine.Random.Range(-changeDistance, changeDistance), 
                                                UnityEngine.Random.Range(-changeDistance, changeDistance), 
                                                UnityEngine.Random.Range(-0, 0));
        
        changeTime = UnityEngine.Random.Range(howLongmin, howLongmax);
    }
    

}