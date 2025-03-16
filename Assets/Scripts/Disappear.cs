using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Disappear : MonoBehaviour
{   
    //for first person controller 
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }

    // //for vr
    // private void Start()
    // {
    //     // Get the XRGrabInteractable component and subscribe to select event
    //     var interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
    //     if (interactable != null)
    //     {
    //         interactable.selectEntered.AddListener(OnGrabbed);
    //     }
    // }

    // private void OnGrabbed(SelectEnterEventArgs args)
    // {
    //     gameObject.SetActive(false); // Disables the object when grabbed
    // }
}
