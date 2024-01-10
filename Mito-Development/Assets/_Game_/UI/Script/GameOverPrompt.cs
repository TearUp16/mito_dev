using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameOverPrompt : MonoBehaviour
{
    [SerializeField] GameObject gameOverPrompt, currentPanel, nextPanel;

    public void OpenGameOverPanel(){
        gameOverPrompt.SetActive(true);
        Time.timeScale = 0;
        
    }
    public void PanelChange(){
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);
    }
}
