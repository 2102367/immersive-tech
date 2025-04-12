using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;
public class PotionBottle : MonoBehaviour
{
    private void OnGrabbed(SelectEnterEventArgs args)
    {
        GetComponent<ParticleSystem>().Stop();
    }

    private void OnMouseDown()
    {
        GetComponent<ParticleSystem>().Stop();
    }


    void OnTriggerEnter(Collider other)
    {   
        if(other.tag == "TreeOfLife"){
            SceneManager.LoadScene("Finish");
        }
    }
}
