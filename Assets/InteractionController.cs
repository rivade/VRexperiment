using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Timeline;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractionController : MonoBehaviour
{
    void Start()
    {
        ActionBasedController controller = GetComponent<ActionBasedController>();

        controller.activateAction.action.started += OnTrigger;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnTrigger(InputAction.CallbackContext ctx)
    {
        XRRayInteractor interactor = GetComponentInChildren<XRRayInteractor>();

        foreach (IXRSelectInteractable interactable in interactor.interactablesSelected)
        {
            GameObject maybeAGun = interactable.transform.gameObject;
            if (maybeAGun.TryGetComponent<GunController>(out GunController gun))
            {
                gun.PullTrigger();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
