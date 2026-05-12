using UnityEngine;
using UnityEngine.InputSystem;
using static input;
// thanks to max!
public class scroll : MonoBehaviour
{
    InputAction mouseClick, mousePosition; 
    Vector3 currentWorldPosition, clickedPosition;
    bool isClicking = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input.OnClickEvent += OnClick;

        mousePosition = InputSystem.actions.FindAction("Point");
        mouseClick = InputSystem.actions.FindAction("Click"); // 
    }

    void OnClick(object sender, input.ClickOnArgs args)
    {
        clickedPosition = args.clickPosition;
        isClicking = true;
    }

    void OnRelease()
    {
        isClicking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isClicking)
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(mousePosition.ReadValue<Vector2>()), out hit))
            {
                currentWorldPosition = hit.point;
            }

            Debug.Log(clickedPosition.y - currentWorldPosition.y);

            Camera.main.transform.position += Vector3.up * (clickedPosition.y - currentWorldPosition.y);
            if (mouseClick.WasReleasedThisFrame())
            {
                OnRelease();
            }
        }
        
        
    }
}
