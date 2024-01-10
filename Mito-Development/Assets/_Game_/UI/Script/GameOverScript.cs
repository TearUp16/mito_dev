using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    int currentScore, highscore;
    [SerializeField] TMP_Text scoreText, highScoreText;
    private void Awake() {
        currentScore = PlayerPrefs.GetInt("CurrentScore");
        highscore = PlayerPrefs.GetInt("Top1Score");
        SetScore();
        SetHighScore();
    }

    void SetScore(){
        scoreText.text = currentScore.ToString();
        PlayerPrefs.SetInt("CurrentScore", 0);
    }

    void SetHighScore(){
        if(currentScore <= highscore){
            highScoreText.text = highscore.ToString();
        }else{
            highScoreText.text = currentScore.ToString();
        }
        
    }

}
