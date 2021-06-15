using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentAwake : MonoBehaviour
{

    public GameObject userPlayer;
    public float noticeRange = 100f;
    public UnityEngine.AI.NavMeshAgent nav;
    public float currentDistance;

    // Start is called before the first frame update
    void Start()
    {
        userPlayer = GameObject.Find("UserPlayer");
        nav = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
            currentDistance = Vector3.Distance(userPlayer.transform.position, transform.position);

            if(currentDistance<=noticeRange)
            {
                nav.enabled = true;
                nav.SetDestination(userPlayer.transform.position);
            }

            else {
                nav.enabled = false;
            }
    }

  
}
