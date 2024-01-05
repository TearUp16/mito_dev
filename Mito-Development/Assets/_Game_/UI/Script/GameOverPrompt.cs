using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameOverPrompt : MonoBehaviour
{
    [SerializeField] GameObject gameOverPrompt, currentPanel, nextPanel;
    bool isDead = false;
    
    public int health;

    public void OpenGameOverPanel(){
        gameOverPrompt.SetActive(true);
        Time.timeScale = 0;
        
    }
    public void PanelChange(){
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);
    }
}
