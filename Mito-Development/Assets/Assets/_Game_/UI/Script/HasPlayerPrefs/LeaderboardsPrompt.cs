using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeaderboardsPrompt : MonoBehaviour
{
    string p1,p2,p3;
    int s1,s2,s3;
    [SerializeField] TMP_Text tp1,tp2,tp3,ts1,ts2,ts3;
    [SerializeField] GameObject leaderboardsPrompt;

    void Start()
    {
        p1 = PlayerPrefs.GetString("Top1Player");
        p2 = PlayerPrefs.GetString("Top2Player");
        p3 = PlayerPrefs.GetString("Top3Player");
        s1 = PlayerPrefs.GetInt("Top1Score");
        s2 = PlayerPrefs.GetInt("Top2Score");
        s3 = PlayerPrefs.GetInt("Top3Score");

        tp1.SetText(p1);
        tp2.SetText(p2);
        tp3.SetText(p3);
        ts1.SetText(s1.ToString());
        ts2.SetText(s2.ToString());
        ts3.SetText(s3.ToString());
    }
    
    public void openLeaderBoards(){
        leaderboardsPrompt.SetActive(true);
    }
    public void Close(){
        leaderboardsPrompt.SetActive(false);
    }
}
