using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Akimbo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name=="UserPlayer")
        {
            col.gameObject.GetComponent<GunSelect>().akimbo = true;
        }
        
    }
}
