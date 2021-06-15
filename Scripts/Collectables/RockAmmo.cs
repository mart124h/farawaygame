using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockAmmo : MonoBehaviour
{

    public int amount;
    public GameManager gameManager;
    public GameObject collectable;
    public GameObject userPlayer;

    public bool followPlayer;
    public float distance = 10f;
    public float currentDistance;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if(followPlayer==true)
        {
            userPlayer = GameObject.Find("UserPlayer");
            currentDistance = Vector3.Distance(userPlayer.transform.position, this.gameObject.transform.position);

             if(currentDistance<=distance)
             {
                collectable.GetComponent<FollowPlayer>().enabled = true;

             }
        }
    }
    

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name=="UserPlayer")
        {
            //this.gameObject.GetComponent<AudioSource>().Play();
            gameManager.rockAmmo += amount;
            StartCoroutine("DeathTimer");
        }
        
    }

    IEnumerator DeathTimer()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(collectable.gameObject);

    }
}
