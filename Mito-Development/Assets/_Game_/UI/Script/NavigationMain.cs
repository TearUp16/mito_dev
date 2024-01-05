using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NavigationMain : MonoBehaviour
{
    AudioManager audioManager;
    private void Awake() {
        audioManager = GameObject.FindGameObjectsWithTag("Audio")[0].GetComponent<AudioManager>();
    }
    public void OnHomeClick(){
        audioManager.PlaySFX(audioManager.buttonClick);
        SceneManager.LoadScene("Title Screen Main");
    }

    public void OnPlayClick(){

        SceneManager.LoadScene("Play Scene");
        //SceneManager.LoadScene("Story");
    }

    public void OnStartGame()
    {
        SceneManager.LoadScene("Apolaki");
    }

    public void OnHeroesClick(){
        audioManager.PlaySFX(audioManager.buttonClick);
        SceneManager.LoadScene("Heroes Scene");
    }
    public void OnStoryClick(){
        audioManager.PlaySFX(audioManager.buttonClick);
        SceneManager.LoadScene("Story Scene");
    }
    
    public void OnHelpClick(){
        SceneManager.LoadScene("Help Scene");
    }
    public void OnPlayButton()
    {
        audioManager.PlaySFX(audioManager.gameStart);
        SceneManager.LoadScene("SampleScene");
    }

    
}
