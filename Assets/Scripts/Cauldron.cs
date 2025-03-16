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
            gsm.mushrooms++;
            Destroy(other.gameObject);
        }
        if(other.tag == "Crystal"){
            gsm.crystals++;
            Destroy(other.gameObject);
        }
        if(other.tag == "Flower"){
            gsm.flowers++;
            Destroy(other.gameObject);
        }        
    }
}
