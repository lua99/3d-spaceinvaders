using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePos;
    public GameObject bullet;
    public float timeBetweenShots;
    private bool canShot = true;

    public float arcRange = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.instance.isPaused)
        {
            if (Input.GetMouseButtonDown(0) && canShot)
            {
                Shoot();

            }
        }

       

        
    }


    void Shoot()
    {
        Instantiate(bullet, firePos.position, firePos.rotation);
        AudioManager.instance.PlaySfx(2);
        
        StartCoroutine(ShootDelay());
    }

    IEnumerator ShootDelay()
    {
        canShot = false;
        yield return new WaitForSeconds(timeBetweenShots);
        canShot = true;
    }
}
