using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockCounter : UICollectableCounter
{
    // Start is called before the first frame update
    void Start()
    {
        counterText = GameObject.Find("RockCounter");
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.rockAmmo>=1)
        {

            counterText.GetComponent<Text>().text = "" + gameManager.rockAmmo;
            
        }

         if(gameManager.rockAmmo<=0)
        {
            
            counterText.GetComponent<Text>().text = "∞";
            
        }
    }
}
