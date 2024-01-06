using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryPlayer : MonoBehaviour
{
    AudioManager audioManager;
    private void Awake() {
        audioManager = GameObject.FindGameObjectsWithTag("Audio")[0].GetComponent<AudioManager>();
    }
    [SerializeField] string ch1, ch2, ch3, ch4;
    public void Chapter1(){
        audioManager.PlaySFX(audioManager.buttonClick);
        SceneManager.LoadScene(ch1);
    }
    public void Chapter2(){
        audioManager.PlaySFX(audioManager.buttonClick);
        SceneManager.LoadScene(ch2);
    }
    public void Chapter3(){
        audioManager.PlaySFX(audioManager.buttonClick);
        SceneManager.LoadScene(ch3);
    }
    public void Chapter4(){
        audioManager.PlaySFX(audioManager.buttonClick);
        SceneManager.LoadScene(ch4);
    }
}
