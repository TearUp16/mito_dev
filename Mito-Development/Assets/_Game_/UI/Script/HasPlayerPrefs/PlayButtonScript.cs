using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    AudioManager audioManager;
    string hasplayed;

    private void Awake() {
        audioManager = GameObject.FindGameObjectsWithTag("Audio")[0].GetComponent<AudioManager>();
    }
    public void PlayButtonClickEvent(){
        audioManager.PlaySFX(audioManager.buttonClick);
        hasplayed = PlayerPrefs.GetString("PlayerHasPlayed");

        if (hasplayed == "true"){
           GoToCharacterSelection();
           //PlayerPrefs.SetString("PlayerHasPlayed", "false"); //temporary
        }else{
            PlayerPrefs.SetString("PlayerHasPlayed", "true");
            PlayerPrefs.SetString("IntroHasPlayed", "false");
            PlayStoryIntro();
           
        }
    }

    public void PlayStoryIntro(){
        SceneManager.LoadScene("Ch1_Page1");


    }
    public void GoToCharacterSelection(){
        SceneManager.LoadScene("Play Scene");
    }
}
