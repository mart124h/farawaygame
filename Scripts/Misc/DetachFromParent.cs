using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetachFromParent : MonoBehaviour
{

   public Transform parent;
    

    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        if(parent.GetComponent<HitDetection>().detachChildren==true)
        {
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            this.gameObject.GetComponent<Collider>().enabled = true;
            StartCoroutine("Killed");
        }        
    }

    IEnumerator Killed()
    {
        yield return new WaitForSeconds(parent.GetComponent<HitDetection>().despawnTimer);
        Destroy(this.gameObject);
        
    }

}
