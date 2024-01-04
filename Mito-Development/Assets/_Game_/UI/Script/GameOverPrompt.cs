using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPrompt : MonoBehaviour
{
    [SerializeField] GameObject gameOverPrompt, currentPanel, nextPanel;
    bool isDead = false;

    void OpenGameOverPanel(){
        if(isDead == true){
            gameOverPrompt.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void PanelChange(){
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);
    }
}
