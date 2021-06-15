using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryoChamberDoor : MonoBehaviour
{

    public bool selected;
    public float magnitude;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "DamagePrefab")
        {
            Destroy(col.gameObject);

            if(selected==true)
            {
                Rigidbody rigi = gameObject.AddComponent<Rigidbody>() as Rigidbody;
                GameObject clone;
                    // calculate force vector
                    var force = transform.position - col.transform.position;
     // normalize force vector to get direction only and trim magnitude
                    force.Normalize();
                    gameObject.GetComponent<Rigidbody>().AddForce(force * magnitude);
                    this.gameObject.GetComponent<AudioSource>().Play();
                    StartCoroutine("Destroyed");
            }

            
        }

    }


    IEnumerator Destroyed ()
    {
        this.gameObject.name = "CryoChamberDoorDestroyed";
        yield return new WaitForSeconds(7);
        Destroy(this.gameObject);
    }
}
