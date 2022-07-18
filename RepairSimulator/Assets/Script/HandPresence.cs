using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandPresence : MonoBehaviour
{
        [SerializeField] private Animator _handAnimator;
        [SerializeField] private InputActionReference _triggerActionReference;
        [SerializeField] private InputActionReference _gripActionReference;
        
        private Boolean Trigger { get; set; }
        
        private Boolean Grip { get; set; }
        
        private void OnEnable()
        {
            _triggerActionReference.action.performed += Trigger_Performed;
            _triggerActionReference.action.canceled += Trigger_Canceled;

            _gripActionReference.action.performed += Grip_Performed;
            _gripActionReference.action.canceled += Grip_Canceled;
        }

        private void OnDisable()
        {
            _triggerActionReference.action.performed -= Trigger_Performed;
            _triggerActionReference.action.canceled -= Trigger_Canceled;

            _gripActionReference.action.performed -= Grip_Performed;
            _gripActionReference.action.canceled -= Grip_Canceled;
        }

        private void Trigger_Performed(InputAction.CallbackContext obj)
        {
            Trigger = true;
            //_handAnimator
        }

        private void Trigger_Canceled(InputAction.CallbackContext obj)
        {
            Trigger = false;
            //_handAnimator
        }

        private void Grip_Performed(InputAction.CallbackContext obj) => Grip = true;

        private void Grip_Canceled(InputAction.CallbackContext obj) => Grip = false;
    }