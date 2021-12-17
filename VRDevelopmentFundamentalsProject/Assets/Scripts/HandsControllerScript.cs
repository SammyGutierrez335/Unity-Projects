using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandsControllerScript : MonoBehaviour
{
    //SerializeField allows us to see them in inspector without making them public.
    //References allow us to provide custom actions
    [SerializeField] InputActionReference gripInputAction;
    [SerializeField] InputActionReference triggerInputerAction;

    Animator handAnimator;
    
    //awake method is Unity's script that runs when component is being loaded (before start method)
    private void Awake() 
    {
        handAnimator = GetComponent<Animator>();
    }

    // these methods are called when the scripts are enabled or disabled. Great for callbacks
    private void OnEnable()
    {
        //when these action references start performing their actions execute the method called GripPressed/TriggerPressed
        gripInputAction.action.performed += GripPressed;
        triggerInputerAction.action.performed += TriggerPressed;
    }

    private void TriggerPressed(InputAction.CallbackContext obj)
    {
        //setFloat allows us to set Animator controller and set them for a particular parameter
        //sets the trigger paramater to the value received from controller.
        handAnimator.SetFloat("Trigger", obj.ReadValue<float>());
    }

    private void GripPressed(InputAction.CallbackContext obj)
    {
        handAnimator.SetFloat("Grip", obj.ReadValue<float>());
    }

    private void OnDisable()
    {
        gripInputAction.action.performed -= GripPressed;
        triggerInputerAction.action.performed -= TriggerPressed;
    }
}
