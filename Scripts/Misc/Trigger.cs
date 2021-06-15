using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    
    public GameObject prefab;


    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name=="UserPlayer")
        {
            prefab.SetActive(true);
            Destroy(this.gameObject);
        }
        
    }
}
