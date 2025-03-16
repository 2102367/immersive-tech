using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameStateManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("ObjectiveText").GetComponent<TextMeshProUGUI>().SetText("Objective: Find the recipe scroll for the antidote.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
