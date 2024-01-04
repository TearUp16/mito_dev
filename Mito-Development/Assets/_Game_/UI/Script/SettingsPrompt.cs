using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPrompt : MonoBehaviour
{
    [SerializeField] GameObject settingsPrompt;
    public void openSettings(){
        settingsPrompt.SetActive(true);
    }

    public void Close(){
        settingsPrompt.SetActive(false);

    }
}
