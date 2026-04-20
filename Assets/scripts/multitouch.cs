using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;

public class multitouch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnhancedTouchSupport.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(UnityEngine.InputSystem.EnhancedTouch.Touch touches in UnityEngine.InputSystem.EnhancedTouch.Touch.activeTouches)
        {
            Debug.Log(touches.phase);
        }
    }
}
