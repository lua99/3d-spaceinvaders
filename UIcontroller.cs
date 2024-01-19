using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UIcontroller : MonoBehaviour
{
    public Image damageEffect;
    public float damageAlpha = 0.2f;
    public float damageFadeSpeed = 0.5f;

    public static UIcontroller instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(damageEffect.color.a != 0)
        {
            damageEffect.color = new Color(damageEffect.color.r, damageEffect.color.g, damageEffect.color.b, Mathf.MoveTowards(damageEffect.color.a,0f,damageFadeSpeed*Time.deltaTime));
        }

        
    }

    public void ShowDamage()
    {
        damageEffect.color = new Color(damageEffect.color.r, damageEffect.color.g, damageEffect.color.b, 0.2f);
    }
  
}
