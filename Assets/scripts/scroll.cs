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
        //either here the sound goes
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
                //or here the sound goes
            }

            Debug.Log(clickedPosition.y - currentWorldPosition.y);

            Camera.main.transform.position += Vector3.up * (clickedPosition.y - currentWorldPosition.y);

            //clamps the camera 
            Camera.main.transform.position = new Vector3(
                    Mathf.Clamp(Camera.main.transform.position.x, 0, 1),
                    Mathf.Clamp(Camera.main.transform.position.y, -184, 203),
                    Mathf.Clamp(Camera.main.transform.position.z, -109, 110)

                );
            
            
            if (mouseClick.WasReleasedThisFrame())
            {
                OnRelease();
            }
        }
        
        
    }
}
