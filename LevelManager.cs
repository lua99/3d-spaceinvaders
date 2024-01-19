using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    public GameObject[] enemies;

    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    void Update()
    {
        // check if all enemies are destoyed
        if (AreallEnemiesDestroyed())  
        {
            LoadnextLevel();
        }
        
    }

   bool AreallEnemiesDestroyed()
    {
        foreach(GameObject enemy in enemies)
        {
            if(enemy != null)
            {
                return false; //at least one enemy is still alive 
            }
        }

        return true; // all enemies are destoyed ;

    }

   void LoadnextLevel()
    {
       int currentScene= SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);

    }

   
}
