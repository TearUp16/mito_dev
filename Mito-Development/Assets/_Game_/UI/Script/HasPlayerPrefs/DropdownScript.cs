using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownScript : MonoBehaviour
{
    AudioManager audioManager;
     private void Awake() {
        audioManager = GameObject.FindGameObjectsWithTag("Audio")[0].GetComponent<AudioManager>();
    }
    // Start is called before the first frame update
    public void OnValueChanged(int val)
    {
        switch (val)
        {
            case 0:
            PlayerPrefs.SetInt("Track", val);
            audioManager.PlayMusic(audioManager.defaultBackground);
            break;
            case 1:
            PlayerPrefs.SetInt("Track", val); 
            audioManager.PlayMusic(audioManager.track1Background);
            break;
            case 2: 
            PlayerPrefs.SetInt("Track", val);
            audioManager.PlayMusic(audioManager.track2Background);
            break;
        }
        
    }
}
