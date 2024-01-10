using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider musicSlider, sfxSlider;
    float minValue, musicVolume, sfxVolume;
    bool musicIsMuted = false;
    bool sfxIsMuted = false;
    

    private void Start() {
        if(PlayerPrefs.HasKey("musicvolume")){
            LoadMusicVolume();
        }
        else{
            SetMusicVolume();
        }
        if(PlayerPrefs.HasKey("sfxvolume")){
            LoadSFXVolume();
        }
        else{
            SetSFXVolume();
            
        }
    }
    public void SetMusicVolume(){
        musicVolume = musicSlider.value;
        mixer.SetFloat("Music", Mathf.Log10(musicVolume)*20);
        PlayerPrefs.SetFloat("musicvolume", musicVolume);
    }
    public void SetSFXVolume(){
        sfxVolume = sfxSlider.value;
        mixer.SetFloat("SFX", Mathf.Log10(sfxVolume)*20);
        PlayerPrefs.SetFloat("sfxvolume", sfxVolume);
    }
    void LoadMusicVolume(){
        musicSlider.value = PlayerPrefs.GetFloat("musicvolume");
        SetMusicVolume();
    }
    void LoadSFXVolume(){
        sfxSlider.value = PlayerPrefs.GetFloat("sfxvolume");
        SetSFXVolume();
    }

    public void MuteMusic(bool mute)
    {
        minValue = 0.0001f;
        // Set the master volume of the mixer group
        mixer.SetFloat("Music", mute ? Mathf.Log10(minValue)*20 : Mathf.Log10(musicVolume)*20);
    }

    public void OnMusicMute(){
        if(musicIsMuted){
            MuteMusic(false);  // Unmute music
            musicIsMuted = false;
            musicSlider.interactable = true;
        }else{
            MuteMusic(true);  // Mute music
            musicIsMuted = true;
            musicSlider.interactable = false;
        }
    }

    public void MuteSFX(bool mute)
    {
        minValue = 0.0001f;
        // Set the master volume of the mixer group
        mixer.SetFloat("SFX", mute ? Mathf.Log10(minValue)*20 : Mathf.Log10(sfxVolume)*20);
    }

    public void OnSFXMute(){
        if(sfxIsMuted){
            MuteSFX(false);  // Unmute music
            sfxIsMuted = false;
            sfxSlider.interactable = true;
        }else{
            MuteSFX(true);  // Mute music
            sfxIsMuted = true;
            sfxSlider.interactable = false;
        }
    }
}
