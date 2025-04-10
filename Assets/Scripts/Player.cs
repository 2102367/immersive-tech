using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if(other.tag == "Portal 1"){
            SceneManager.LoadScene("World 1");
        }
        if(other.tag == "Portal 2"){
            SceneManager.LoadScene("World 2");
        }
    }
}
