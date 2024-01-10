using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoardScript : MonoBehaviour
{
    // Start is called before the first frame update
    int score;
    int top1 = PlayerPrefs.GetInt("Top1Score");
    int top2 = PlayerPrefs.GetInt("Top2Score");
    String player;
    String top_p1 = PlayerPrefs.GetString("Top1Player");
    String top_p2 = PlayerPrefs.GetString("Top2Player");
    [SerializeField] Button submitButton, anonymousButton;
    [SerializeField] GameObject newHighScorePanel, highScoreManager, gameOverPrompt, thisPanel;
    [SerializeField] TMP_InputField input;
    private void Awake() {
        score = PlayerPrefs.GetInt("CurrentScore");
    }

    void SetHighScore(){
        
            PlayerPrefs.SetInt("Top3Score", top2);
            PlayerPrefs.SetString("Top3Player",top_p2);

            PlayerPrefs.SetInt("Top2Score", top1);
            PlayerPrefs.SetString("Top2Player",top_p1);

            PlayerPrefs.SetInt("Top1Score", score);
            PlayerPrefs.SetString("Top1Player",player);
        
    }
    public void openHighScoreManager(){
        highScoreManager.SetActive(true);
    }
    public void onSubmitButton(){    
        player = input.text;
        SetHighScore();
        gameOverPrompt.SetActive(true);
        thisPanel.SetActive(false);
    }
    public void onAnonymousButton(){
        player = "Anonymous";
        SetHighScore();
        gameOverPrompt.SetActive(true);
        thisPanel.SetActive(false);
        
    }
    
}
