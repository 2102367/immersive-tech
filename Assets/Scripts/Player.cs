using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class Player : MonoBehaviour
{
    public Vector3 teleportLocation;

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Portal 1"){
            SceneManager.LoadScene("World 1");
        }
        if(other.tag == "Portal 2"){
            SceneManager.LoadScene("World 2");
        }
        if(other.tag == "Reset"){
            transform.position = teleportLocation;
        }
    }
}
