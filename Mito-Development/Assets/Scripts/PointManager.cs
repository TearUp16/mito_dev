using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public int score, targetScore;
    public TMP_Text scoreText;
    [SerializeField] GameObject transition;
    private void Awake() {
        LoadScore();
        scoreText.text = "Score: " + score;
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
        SaveScore();
        if(score == targetScore){
            Invoke("EnableTrans", 1f);
        }

    }

    void SaveScore(){
        PlayerPrefs.SetInt("CurrentScore", score);
    }

    void LoadScore(){
        score = PlayerPrefs.GetInt("CurrentScore");
    }

    public void ResetScore(){
         
            PlayerPrefs.SetInt("CurrentScore", 0);
    }
    
    void EnableTrans(){
        transition.SetActive(true);
    }
}
