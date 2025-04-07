using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public GameStateManager gsm;
    void Start()
    {
        gsm = GameObject.Find("GameStateManager").GetComponent<GameStateManager>();

    }

    // Update is called once per frame
    void Update()
    {
    
    }


    void OnTriggerEnter(Collider other)
    {   
        if(other.tag == "Mushroom"){
            GetComponent<AudioSource>().Play();
            gsm.mushrooms++;
            Destroy(other.gameObject);
        }
        if(other.tag == "Crystal"){
            GetComponent<AudioSource>().Play();
            gsm.crystals++;
            Destroy(other.gameObject);
        }
        if(other.tag == "Flower"){
            GetComponent<AudioSource>().Play();
            gsm.flowers++;
            Destroy(other.gameObject);
        }        
    }
}
