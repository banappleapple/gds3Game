using UnityEngine;
using System;
public class ClickOnObject : MonoBehaviour
{
    private float changeTime = 7.0f;
    public float howLongmin = 1.0f;
    public float howLongmax = 7.0f;
    public float changeDistance = 4;
    void Update()
    {

        changeTime -= Time.deltaTime;

        if (changeTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        
        this.transform.position = new Vector3(UnityEngine.Random.Range(-changeDistance, changeDistance), UnityEngine.Random.Range(-changeDistance, changeDistance), 0);
        changeTime = UnityEngine.Random.Range(howLongmin, howLongmax);
    }
    

}