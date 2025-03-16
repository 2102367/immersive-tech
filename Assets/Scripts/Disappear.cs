using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class Disappear : MonoBehaviour
{   
    // public GameStateManager gsm;
    public GameObject ingredientText;

    // public TMP_text objectiveText;

    //for vr
    private void Start()
    {
        // Get the XRGrabInteractable component and subscribe to select event
        var interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        if (interactable != null)
        {
            interactable.selectEntered.AddListener(OnGrabbed);
        }

        
    }

    private void OnGrabbed(SelectEnterEventArgs args)
    {
        GameObject.Find("ObjectiveText").GetComponent<TextMeshProUGUI>().SetText("Objective: Collect ingredients and put them in the cauldron near the portal.");
        ingredientText.SetActive(true);
        gameObject.SetActive(false);
        
    }
    
    //for first person controller 
    private void OnMouseDown()
    {
        GameObject.Find("ObjectiveText").GetComponent<TextMeshProUGUI>().SetText("Objective: Collect ingredients and put them in the cauldron near the portal.");
        ingredientText.SetActive(true);
        gameObject.SetActive(false);
    }


}
