using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableRotation : MonoBehaviour
{

    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * 0, speed, 0, Space.Self);
    }
}
