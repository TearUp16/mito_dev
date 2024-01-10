using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;

    public AudioClip defaultBackground;
    public AudioClip track1Background;
    public AudioClip track2Background;
    public AudioClip buttonClick;
    public AudioClip quitButtonClick;
    public AudioClip playButtonClick;
    public AudioClip gameStart;
    public AudioClip selectClick;
    public AudioClip closeClick;
    public AudioClip infoClick;
    public AudioClip nextClick;
    public AudioClip prevClick;
    [SerializeField] Dropdown dropDown;


    public static AudioManager instance;

    private void Awake() {
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }
    private void Start() {
        musicSource.clip = defaultBackground;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip){
        SFXSource.PlayOneShot(clip);
    }
    
    public void PlayMusic(AudioClip clip){
        musicSource.clip = clip;
        musicSource.loop = true;
        musicSource.Play();
    }

}
