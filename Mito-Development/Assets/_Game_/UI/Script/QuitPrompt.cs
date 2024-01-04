using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitPrompt : MonoBehaviour
{
    [SerializeField] GameObject quitPrompt;
    public void Quit(){
        quitPrompt.SetActive(true);
    }
    public void Confirm(){
        quitPrompt.SetActive(false);
        
    }
    public void Cancel(){
        quitPrompt.SetActive(false);

    }
    
}
