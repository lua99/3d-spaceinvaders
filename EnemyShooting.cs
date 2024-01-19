using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;
    public float minTimebetweenShots;
    public float maxTimebetweenShots;
    
    void Start()
    {
        StartCoroutine(ShootRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void Shoot()
    {
        Instantiate(bullet, firePos.position, firePos.rotation);
        AudioManager.instance.PlaySfx(0);
    }


    IEnumerator ShootRoutine()
    {
        while(true){

            yield return new WaitForSeconds(Random.Range(minTimebetweenShots, maxTimebetweenShots));
            Shoot();

        }
    }
}
