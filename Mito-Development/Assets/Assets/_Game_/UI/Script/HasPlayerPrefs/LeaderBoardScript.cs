using System;
using System.Collections;
using System.Collections.Generic;
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
    [SerializeField] InputField nickname;
    [SerializeField] Button submitButton, anonymousButton;
    [SerializeField] GameObject newHighScorePanel, highScoreManager;

    void Awake(){
        score = 0;
        if(score > top1){
            openNewHighScorePanel();
        }
    }
    void SetHighScore(int score, String player){
        if(score > top1){
            PlayerPrefs.SetInt("Top3Score", top2);
            PlayerPrefs.SetString("Top3Player",top_p2);

            PlayerPrefs.SetInt("Top2Score", top1);
            PlayerPrefs.SetString("Top2Player",top_p1);

            PlayerPrefs.SetInt("Top1Score", score);
            PlayerPrefs.SetString("Top1Player",player);
        }
    }
    public void openNewHighScorePanel(){
        newHighScorePanel.SetActive(true);
    }
    public void openHighScoreManager(){
        highScoreManager.SetActive(true);
    }
    public void onSubmitButton(){
        score = 0;
        player = nickname.text;
        SetHighScore(score, player);
    }
    public void onAnonymousButton(){
        score = 0;
        player = "Anonymous";
        SetHighScore(score, player);
    }
}
