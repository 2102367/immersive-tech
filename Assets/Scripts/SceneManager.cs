using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public int currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {   
        if(other.tag == "Player"){

        }
    }
}
