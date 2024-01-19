using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float bulletSpeed;
    private Rigidbody rb;
    public float bulletLifetime;

    public GameObject impact;


    private void Awake()
    {
        Destroy(gameObject, bulletLifetime);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Instantiate(impact, other.transform.position, Quaternion.identity);
            AudioManager.instance.PlaySfx(1);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(impact, collision.transform.position, Quaternion.identity);
        Destroy(gameObject);
        
    }
}
