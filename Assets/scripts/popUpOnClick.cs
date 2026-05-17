using UnityEngine;
using UnityEngine.InputSystem;
using static input;
public class popUpOnClick : MonoBehaviour
{

    InputAction mouseClick;
    public GameObject fishInstance;
    private GameObject clickedOnObject = null;
    public Animator panelAnimator;
    private string clickedBooleanName = "clicked";
    private bool isVisible = false;
    bool isClicking = false;

    void Start()
    {
        input.OnClickEvent += OnClick;

        mouseClick = InputSystem.actions.FindAction("Click");  
    }

    void OnClick(object sender, input.ClickOnArgs args)
    {
        isClicking = true;
        clickedOnObject = args.clickedOnObject;
        if (isVisible == false && clickedOnObject == fishInstance)
        {
            panelAnimator.SetBool(clickedBooleanName, true);
            isVisible = true;
        }
        if (isVisible == true && clickedOnObject != fishInstance)
        {
            panelAnimator.SetBool(clickedBooleanName, false);
            isVisible = false;
        }
    }

    private void Update()
    {
        
    }

    //public void ClosePopup()
    //{
    //    popupPanel.SetActive(false);
    //}
}
