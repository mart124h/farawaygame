using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun1 : MonoBehaviour
{


    public GameManager gameManager;

    public GameObject gunPrefab;
    

    public bool canShoot = true;
    public bool automatic = false;

    public float fireRate;
    public float shootingPower;

    public Rigidbody bullet;
    public Transform bulletSpawner;

    public ParticleSystem ps;

    public Transform shellSpawner;
    public Rigidbody shellPrefab;
    public float rejectingPower;


    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        ps = GameObject.Find("MuzzleFlash").GetComponent<ParticleSystem>();
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(automatic==false)
        {
            
             if(Input.GetMouseButtonDown(0) && canShoot==true)
                {
                canShoot = false;
                ps.Stop();
                gunPrefab.GetComponent<GunAnimator>().shoot = true;
                StartCoroutine("Shoot");

             }

        }

        if(automatic==true){
            
             if(Input.GetMouseButton(0) && canShoot==true){
                canShoot = false;
                ps.Stop();
                gunPrefab.GetComponent<GunAnimator>().shoot = true;
                StartCoroutine("Shoot");

             }

        }
       

        
    }

    IEnumerator Shoot()
    {
        Rigidbody clone;

        clone = Instantiate(bullet, bulletSpawner.position, bulletSpawner.rotation);
        clone.AddForce(bulletSpawner.forward * shootingPower);


        
        ps.Play();

        Rigidbody shellClone;
        shellClone = Instantiate(shellPrefab, shellSpawner.position, shellSpawner.rotation);
        shellClone.AddForce(shellSpawner.right * rejectingPower);
        
        if(automatic==true)
        {
            gameManager.rockAmmo -= 1;
        }

        yield return new WaitForSeconds(fireRate);
        canShoot = true;
    }

}
