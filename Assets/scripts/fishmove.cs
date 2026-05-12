using UnityEngine;
using System;
using Unity.VisualScripting;

public class fishmove : MonoBehaviour
{
    Vector3 AimPosition;
    public GameObject toFollow;
    public int speed;
    public Transform target;

    
    //private float fTwo = 0;
    //private float fThree = -90;


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
       
        //faces towards target
        if (targetx > this.transform.position.x)
        {
            //fTwo = 0;
            transform.eulerAngles = new Vector3(0, 0, -90);
        }
        else if (targetx < this.transform.position.x)
        {
            //fTwo = 180;
            transform.eulerAngles = new Vector3(0, 180, -90);
        }
        else if (targetx == this.transform.position.x)
        {
            Debug.Log("not changing");
        }
        
        //angles up/down towards target 
        //if (targety > this.transform.position.y)
        //{
            
        //    transform.eulerAngles += new Vector3(0, fTwo, 20);
        //    //NEEDS TO GO BACK TO NORMAL ON NOT CHANGING
        //}
        //else if (targety < this.transform.position.y)
        //{
            
        //    transform.eulerAngles += new Vector3(0, fTwo, -20);
        //}

    }
}