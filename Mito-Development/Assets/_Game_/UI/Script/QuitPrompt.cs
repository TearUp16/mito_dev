using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitPrompt : MonoBehaviour
{
    
    [SerializeField] GameObject quitPrompt;
    AudioManager audioManager;
    private void Awake() {
        audioManager = GameObject.FindGameObjectsWithTag("Audio")[0].GetComponent<AudioManager>();
    }
    public void Quit(){
        
        quitPrompt.SetActive(true);
    }
    public void Confirm(){
        audioManager.PlaySFX(audioManager.closeClick);
        quitPrompt.SetActive(false);
        
    }
    public void Cancel(){
        audioManager.PlaySFX(audioManager.closeClick);
        quitPrompt.SetActive(false);

    }
    
}
