using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRemote : MonoBehaviour
{

    public bool activated;
    public bool opened;
    public GameObject doorPrefab;
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {

        Animator animator = doorPrefab.GetComponent<Animator>();

        if(activated)
        {
            animator.SetBool("Opening", true);
        }
        else
        {
            animator.SetBool("Opening", false);
        }
    }
}
