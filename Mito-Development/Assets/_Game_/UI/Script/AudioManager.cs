using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;

    public AudioClip background;
    public AudioClip buttonClick;
    public AudioClip quitButtonClick;
    public AudioClip playButtonClick;
    public AudioClip gameStart;
    public AudioClip selectClick;
    public AudioClip closeClick;
    public AudioClip infoClick;
    public AudioClip nextClick;
    public AudioClip prevClick;


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
        musicSource.clip = background;
        musicSource.Play();
    }
    
    public void PlaySFX(AudioClip clip){
        SFXSource.PlayOneShot(clip);
    }

}
