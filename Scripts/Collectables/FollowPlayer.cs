using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject target;
    public float followSpeed;
    
    public void Update()
    {
        target = GameObject.Find("UserPlayer");
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, followSpeed);
            
    }
}
