using UnityEngine;
using UnityEngine.InputSystem;
using static input;

public class scroll : MonoBehaviour
{
    InputAction mousePosition;
    Vector3 currentWorldPosition, clickedPosition;
    bool isClicking = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input.OnClickEvent += OnClick;

        mousePosition = InputSystem.actions.FindAction("Point");
    }

    void OnClick(object sender, input.ClickOnArgs args)
    {
        clickedPosition = args.clickPosition;
        isClicking = true;
    }

    void OnRelease()
    {

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
        }
        
    }
}
