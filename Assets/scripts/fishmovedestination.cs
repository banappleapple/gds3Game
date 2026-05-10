using UnityEngine;
using System;
public class ClickOnObject : MonoBehaviour
{
    public float changeTime = 7.0f;
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
        Debug.Log("ME");
        this.transform.position = new Vector3(UnityEngine.Random.Range(-4, 4), UnityEngine.Random.Range(-4, 4), 0);
        changeTime = UnityEngine.Random.Range(1.0f, 6.0f);
    }
    

}