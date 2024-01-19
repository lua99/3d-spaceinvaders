using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bariccade : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

}
