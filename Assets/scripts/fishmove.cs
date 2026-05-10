using UnityEngine;
using System;
using Unity.VisualScripting;

public class fishmove : MonoBehaviour
{
    Vector3 AimPosition;
    public GameObject toFollow;
    public int speed;
    public Transform target;

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
        float targetx = target.transform.position.x;
        float targety = target.transform.position.y;

        this.transform.position = Vector3.MoveTowards(this.transform.position, AimPosition, Time.deltaTime * speed);
        //transform.LookAt(target);
        //transform.Rotate(Vector3.right * 180);
        //if target.xposition <= this.transform.xposition { Rotationxpos = - 90}
        //else if target poos > this.transform.xposition { Rotationxpos = 90} Or y = 180
        if (targetx > this.transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 0, -90);
        }
        else if (targetx < this.transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 180, -90);
        }
        else if (targetx == this.transform.position.x)
        {
            Debug.Log("not changing");
        }
        if (targety > this.transform.position.y)
        {
            transform.eulerAngles += new Vector3(0, 0, 20);
            //NEEDS TO GO BACK TO NORMAL ON NOT CHANGING
        }
    }
}