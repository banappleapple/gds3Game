using UnityEngine;
using System;

public class fishmove : MonoBehaviour
{
    Vector3 AimPosition;
    public GameObject toFollow;
    public int speed;

    void Start()
    {
        AimPosition = toFollow.transform.position;
    }

    public void SetNewPosition(Vector3 newPostion)
    {
        AimPosition = newPostion;
    }

    void Update()
    {
        AimPosition = toFollow.transform.position;
  
        this.transform.position = Vector3.MoveTowards(this.transform.position, AimPosition, Time.deltaTime * speed);
        
    }
}