using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpan : MonoBehaviour
{

    public float lifeSpan = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, lifeSpan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
