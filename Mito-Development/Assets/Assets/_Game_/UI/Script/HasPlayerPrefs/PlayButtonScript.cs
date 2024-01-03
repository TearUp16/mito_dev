using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    string hasplayed;   
    public void PlayButtonClickEvent(){
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
