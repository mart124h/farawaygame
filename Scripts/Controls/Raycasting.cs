using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Physics;

public class Raycasting : MonoBehaviour
{

    public float range = 1000f;
    public GameObject lastHit;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, this.transform.forward);

        
        if(Physics.Raycast(ray, out hit, range))
        {
            lastHit = hit.transform.gameObject;

            if(lastHit.gameObject.name=="CryoDoor")
            {
                gameManager.gameCursor.SetActive(false);
                gameManager.shootIcon.SetActive(true);

                 if(Input.GetMouseButton(0))
                    {
                        lastHit.GetComponent<CryoChamberDoor>().selected=true;
                    }
            }

            else 
            {
                gameManager.gameCursor.SetActive(true);
                gameManager.shootIcon.SetActive(false);
            }

           if(lastHit.gameObject.name=="RemoteController")
           {
               
               gameManager.gameCursor.SetActive(false);
               gameManager.activateIcon.SetActive(true);

               
                if(Input.GetKeyDown("e"))
                {
                    if(lastHit.GetComponent<DoorRemote>().activated==false)
                    {
                        lastHit.GetComponent<DoorRemote>().activated=true;
                    }
                    else 
                    {
                        lastHit.GetComponent<DoorRemote>().activated=false;
                    }
                }
           }

           else
           {
                 gameManager.activateIcon.SetActive(false);
                 gameManager.gameCursor.SetActive(true);

           }

        }

    }
}
