using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameOverPrompt : MonoBehaviour
{
    [SerializeField] GameObject gameOverPrompt, currentPanel, nextPanel;

    private void Start() {
        gameOverPrompt.SetActive(true);
    }
    public void PanelChange(){
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);

    }
}
