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

    public TMP_Text ingredientsTxt;
    void Start()
    {
        GameObject.Find("ObjectiveText").GetComponent<TextMeshProUGUI>().SetText("Objective: Find the recipe scroll for the antidote.");

    }

    // Update is called once per frame
    void Update()
    {
        ingredientsTxt.SetText($"Mushrooms: {mushrooms}/5\nCrystals: {crystals}/5\nFlowers: {flowers}/5");

    }
}
