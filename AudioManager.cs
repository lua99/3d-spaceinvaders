using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource[] soundEffects;
    public static AudioManager instance;
    public AudioSource Bgm;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySfx(int soundToPlay)
    {
        soundEffects[soundToPlay].Play();
    }
}
