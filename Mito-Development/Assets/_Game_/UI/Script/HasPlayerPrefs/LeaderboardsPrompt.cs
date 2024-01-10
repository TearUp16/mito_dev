using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class LeaderboardsPrompt : MonoBehaviour
{
    AudioManager audioManager;
    string p1,p2,p3;
    int s1,s2,s3;
    [SerializeField] TextMeshProUGUI tp1,tp2,tp3,ts1,ts2,ts3;
    [SerializeField] GameObject leaderboardsPrompt;

    private void Awake() {
        audioManager = GameObject.FindGameObjectsWithTag("Audio")[1].GetComponent<AudioManager>();
    }
    void Start()
    {
        p1 = PlayerPrefs.GetString("Top1Player");
        p2 = PlayerPrefs.GetString("Top2Player");
        p3 = PlayerPrefs.GetString("Top3Player");
        s1 = PlayerPrefs.GetInt("Top1Score");
        s2 = PlayerPrefs.GetInt("Top2Score");
        s3 = PlayerPrefs.GetInt("Top3Score");

        tp1.text = p1;
        tp2.text = p2;
        tp3.text = p3;
        
        ts1.text = s1.ToString();
        ts2.text = s2.ToString();
        ts3.text = s3.ToString();
    }
    
    public void openLeaderBoards(){
        //audioManager.PlaySFX(audioManager.buttonClick);
        leaderboardsPrompt.SetActive(true);
    }
    public void Close(){
        leaderboardsPrompt.SetActive(false);
    }
}
