using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour
{
    public int health;
    public GameObject newObjectPrefab;
    void Start()
    {
        health = 5;
    }

    void Update(){
        if(health == 0){
            Instantiate(newObjectPrefab, transform.position, transform.rotation);
            GetComponent<BoxCollider>().enabled = false;
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Pickaxe"){
            GetComponent<AudioSource>().Play();
            health--;
        }
    }

    // void OnCollisionEnter(Collision collision)
    // {
    //     if(collision.collider.tag == "Pickaxe"){
    //         GetComponent<AudioSource>().Play();
    //         health--;
    //     }
    // }
    
}


// script on ore
// oncollisionenter()
// -other tag --the collision w the pickaxe
// -add some sort of health script
// -when at 0 then diasable object then instantiate ore in same spot
