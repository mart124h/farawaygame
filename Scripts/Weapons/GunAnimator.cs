using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAnimator : MonoBehaviour
{
    public bool shoot;
    public float fireRate;
    public GameObject gunPrefab;
    public Animator animator;
    public AudioClip fireSoundClip;
    public AudioSource fireSound;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = gunPrefab.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {


        if(shoot)
        {
            StartCoroutine("FireRate");
        }
        else
        {
            animator.SetBool("shooting", false);
        }
    }

    IEnumerator FireRate()
    {
        animator.SetBool("shooting", true);
        StartCoroutine("FireShot");
        yield return new WaitForSeconds(0);
        shoot = false;

        
    }

    IEnumerator FireShot()
    {
        fireSound.Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        
    }
}
