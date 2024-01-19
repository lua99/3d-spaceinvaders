using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public static PlayerHealth instance;

    public HealthBar healthbar;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage()
    {
        
        currentHealth--;
        UIcontroller.instance.ShowDamage();
        AudioManager.instance.PlaySfx(3);
        healthbar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
