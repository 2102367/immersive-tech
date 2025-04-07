using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Portal 1"){
            SceneManager.LoadScene("World 1");
        }
        if(other.tag == "Portal 2"){
            SceneManager.LoadScene("World 2");
        }
    }
}
