using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour
{
    public bool isNavAgent = true;
    public float despawnTimer = 7;
    public float magnitude = 5;
    public GameObject deathVFX;
    public GameObject bulletHitVFX;

    public bool detachChildren;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    IEnumerator Killed()
    {
        yield return new WaitForSeconds(despawnTimer);
        Destroy(this.gameObject);
        
    }

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "DamagePrefab")
        {
            this.gameObject.GetComponent<AgentHealth>().hitPoints--;
            GameObject bulletHitVFXClone = Instantiate(bulletHitVFX, col.transform.position, col.transform.rotation);
            Destroy(col.gameObject);


            if(isNavAgent==true && this.gameObject.GetComponent<AgentHealth>().hitPoints<1)
            {
                this.gameObject.GetComponent<FollowTarget>().enabled = false;
                this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                Rigidbody rigi = gameObject.AddComponent<Rigidbody>() as Rigidbody;
                GameObject clone;
                    // calculate force vector
                    var force = transform.position - col.transform.position;
     // normalize force vector to get direction only and trim magnitude
                    force.Normalize();
                    gameObject.GetComponent<Rigidbody>().AddForce(force * magnitude);
                    deathVFX.SetActive(true);
                    this.gameObject.transform.DetachChildren();
                    detachChildren = true;
                    this.gameObject.GetComponent<Collider>().enabled = true;
                    StartCoroutine("Killed");
            }

        }

    }
}
