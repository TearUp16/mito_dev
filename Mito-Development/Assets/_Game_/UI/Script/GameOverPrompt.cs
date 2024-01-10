using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameOverPrompt : MonoBehaviour
{
    [SerializeField] GameObject gameOverPrompt, currentPanel, nextPanel, enterNewHighScorePanel;
    //[SerializeField] GameObject[] unlockCharPanels,unlockStoryPanels;
    //int unlockPanel0,unlockPanel1,unlockPanel2,unlockPanel3,unlockPanel4, score;
    //int top1 = PlayerPrefs.GetInt("Top1Score");

    private void Start() {
        //LoadPanel();
        //UnlockPanel();
        OpenGameOverPrompt();
        
    }
    public void PanelChange(){
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);
    }

    // public void UnlockPanel(){
    //     if(unlockPanel0 == 1){
    //         unlockStoryPanels[0].SetActive(true);
    //         unlockPanel0++;
    //         PlayerPrefs.SetInt("UnlockPanel0", unlockPanel0);
    //     }else if(unlockPanel1 == 1){
    //         unlockStoryPanels[1].SetActive(true);
    //         unlockPanel1++;
    //         PlayerPrefs.SetInt("UnlockPanel1", unlockPanel4);
    //     }else if(unlockPanel2 == 1){
            
    //         unlockStoryPanels[2].SetActive(true);
    //         unlockPanel2++;
    //         PlayerPrefs.SetInt("UnlockPanel2", unlockPanel4);
    //     }else if(unlockPanel3 == 1){
    //         unlockStoryPanels[3].SetActive(true);
    //         unlockPanel3++;
    //         PlayerPrefs.SetInt("UnlockPanel3", unlockPanel4);
    //     }else if(unlockPanel4 == 1){
    //         unlockCharPanels[3].SetActive(true);
    //         unlockPanel4++;
    //         PlayerPrefs.SetInt("UnlockPanel4", unlockPanel4);
    //     }else{
    //         OpenGameOverPrompt();
    //     }

    // }
    public void OpenGameOverPrompt(){
       gameOverPrompt.SetActive(true);
        
        // foreach(var item in unlockStoryPanels){
        //     Destroy(item);
        // }
        // foreach(var item in unlockCharPanels){
        //     Destroy(item);
        // }
        
    }
    // void LoadPanel(){
    //     unlockPanel0 = PlayerPrefs.GetInt("UnlockPanel0");
    //     unlockPanel1 = PlayerPrefs.GetInt("UnlockPanel1");
    //     unlockPanel2 = PlayerPrefs.GetInt("UnlockPanel2");
    //     unlockPanel3 = PlayerPrefs.GetInt("UnlockPanel3");
    //     unlockPanel4 = PlayerPrefs.GetInt("UnlockPanel4");
    //     //questUnlock = PlayerPrefs.GetInt("QuestUnlock");
    // }
    
    // public void NextChar0(){
    //     unlockCharPanels[0].SetActive(true);
    //     Destroy(unlockStoryPanels[0]);
    // }
    // public void NextChar1(){
    //     unlockCharPanels[1].SetActive(true);
    //     Destroy(unlockStoryPanels[1]);
    // }
    // public void NextChar2(){
    //     unlockCharPanels[2].SetActive(true);
    //     Destroy(unlockStoryPanels[2]);
    // }

    
}
