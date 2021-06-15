using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSelect : MonoBehaviour
{
    public bool akimbo;
    public GameObject automaticRifleAkimbo;
    public GameObject automaticRifleAkimbo1;
    public GameObject automaticRifle;
    public GameObject pistol;
    public GameManager gameManager;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.rockAmmo==0 && akimbo==false)
        {
            automaticRifle.GetComponent<Gun>().canShoot=true;
            automaticRifle.SetActive(false);
            pistol.SetActive(true);
        }
        if(gameManager.rockAmmo>0 && akimbo==false)
        {
            
            pistol.SetActive(false);
            automaticRifle.SetActive(true);
        }

        if(gameManager.rockAmmo==0 && akimbo==true)
        {
            automaticRifleAkimbo.SetActive(false);
            automaticRifleAkimbo.GetComponent<Gun>().canShoot=true;
            automaticRifleAkimbo1.GetComponent<Gun>().canShoot=true;
            pistol.SetActive(true);
        }

        if(gameManager.rockAmmo>0 && akimbo==true) 
        {
            automaticRifle.GetComponent<Gun>().canShoot=true;
            automaticRifle.SetActive(false);
            pistol.SetActive(false);
            automaticRifleAkimbo.SetActive(true);
        }
        
    }
}
