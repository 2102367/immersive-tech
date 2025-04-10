using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameStateManager : MonoBehaviour
{   
    //antidote ingredients
    public int mushrooms;
    public int crystals;
    public int flowers;

    public GameObject portalArea;

    public TMP_Text ingredientsTxt;
    void Start()
    {
        mushrooms = 0;
        crystals = 0;
        flowers = 0;
        // GameObject.Find("ObjectiveText").GetComponent<TextMeshProUGUI>().SetText("Objective: Find the recipe scroll for the antidote.");
    }

    // Update is called once per frame
    void Update()
    {
        ingredientsTxt.SetText($"Mushrooms: {mushrooms}/5\nCrystals: {crystals}/2\nFlowers: {flowers}/5");

        if(mushrooms >= 5 && crystals >= 2 && flowers >= 5){
            portalArea.SetActive(true);
        }

    }
}
