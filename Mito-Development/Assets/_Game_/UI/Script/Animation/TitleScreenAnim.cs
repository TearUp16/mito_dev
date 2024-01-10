using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenAnim : MonoBehaviour
{
    [SerializeField] GameObject questPanel, settingsPanel, quitPanel, leaderboardsPanel, panel;
    [SerializeField] GameObject[] buttonset1, buttonset2;
    [SerializeField] GameObject[] highscoreItem;
    [SerializeField] LeanTweenType tweenType;
    [SerializeField] float tweenTime;
    AudioManager audioManager;
    private void Awake() {
        audioManager = GameObject.FindGameObjectsWithTag("Audio")[0].GetComponent<AudioManager>();
    }
    
    private void Start() {
        LeanTween.moveLocal(buttonset1[0], new Vector3(-93.4f,14.7f,1), 0.5f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.moveLocal(buttonset1[1], new Vector3(-93.4f,-9.336006f,1), 0.5f).setEase(LeanTweenType.easeOutCirc).setDelay(0.1f);
        LeanTween.moveLocal(buttonset1[2], new Vector3(-93.4f,-33.372f,1), 0.5f).setEase(LeanTweenType.easeOutCirc).setDelay(0.2f);
        LeanTween.moveLocal(buttonset1[3], new Vector3(-93.4f,-57.40802f,1), 0.5f).setEase(LeanTweenType.easeOutCirc).setDelay(0.3f);
        
        LeanTween.scale(buttonset2[0], new Vector3(1,1,1),0.5f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(buttonset2[1], new Vector3(1,1,1),0.5f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(buttonset2[2], new Vector3(1,1,1),0.5f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(buttonset2[3], new Vector3(1,1,1),0.5f).setEase(LeanTweenType.easeOutCirc);
    }

    //quest animation
    public void QuestSlideIn(){
        audioManager.PlaySFX(audioManager.buttonClick);
        LeanTween.moveLocal(questPanel, new Vector3(0f, 0f, 0f), 0.5f).setEase(LeanTweenType.easeInOutCubic);
        openPanel();
    }
    public void QuestSlideOut(){
        audioManager.PlaySFX(audioManager.closeClick);
        LeanTween.moveLocal(questPanel, new Vector3(0f, -180f, 0f), 0.5f).setEase(LeanTweenType.easeInOutCubic);
        Invoke("closeQuestPanel", 0.5f);
        closePanel();
    }
    public void closeQuestPanel(){
        questPanel.SetActive(false);
    }

    //settings animation
    public void SettingsSlideIn(){
        audioManager.PlaySFX(audioManager.buttonClick);
        LeanTween.moveLocal(settingsPanel, new Vector3(0f, 0f, 0f), 0.5f).setEase(LeanTweenType.easeInOutCubic);
        openPanel();
    }
    public void SettingsSlideOut(){
        audioManager.PlaySFX(audioManager.closeClick);
        LeanTween.moveLocal(settingsPanel, new Vector3(0f, -180f, 0f), 0.5f).setEase(LeanTweenType.easeInOutCubic);
        Invoke("closeSettingsPanel", 0.5f);
        closePanel();
    }
    void closeSettingsPanel(){
        settingsPanel.SetActive(false);
    }

    //quit animation
    public void QuitPanelScaleUp(){
        audioManager.PlaySFX(audioManager.quitButtonClick);
        LeanTween.scale(quitPanel, new Vector3(1f,1f,1f),0.5f).setEase(LeanTweenType.easeInOutElastic);
        openPanel();
    }
    public void QuitPanelScaleDown(){
        audioManager.PlaySFX(audioManager.closeClick);
        LeanTween.scale(quitPanel, new Vector3(0f,0f,0f),0.5f).setEase(LeanTweenType.easeInOutElastic);
        Invoke("closeQuitPanel", 0.5f);
        closePanel();
    }
    void closeQuitPanel(){
        quitPanel.SetActive(false);
    }

    //leaderboards animation
    public void LeaderboardPanelSlideIn(){
        audioManager.PlaySFX(audioManager.buttonClick);
        LeanTween.moveLocal(leaderboardsPanel, new Vector3(0f, 0f, 0f), 0.5f).setEase(LeanTweenType.easeInOutCubic);
        openPanel();
        Invoke("top1Scale", 0.5f);
        Invoke("top2Scale", 0.8f);
        Invoke("top3Scale", 1.3f);
    }
    public void LeaderboardPanelSlideOut(){
        audioManager.PlaySFX(audioManager.closeClick);
        LeanTween.moveLocal(leaderboardsPanel, new Vector3(0f, -180f, 0f), 0.5f).setEase(LeanTweenType.easeInOutCubic);
        Invoke("closeLeaderBoardPanel", 0.5f);
        closePanel();

    }
    void closeLeaderBoardPanel(){
        leaderboardsPanel.SetActive(false);
    }
    void top1Scale(){
        LeanTween.scale(highscoreItem[0], new Vector3(1.2f,1.2f, 0.5f), 0.1f);
        LeanTween.scale(highscoreItem[0], new Vector3(1f,1f,1f), 0.1f).setDelay(0.1f);
    }
    void top2Scale(){
        LeanTween.scale(highscoreItem[1], new Vector3(1.2f,1.2f, 0.5f), 0.1f);
        LeanTween.scale(highscoreItem[1], new Vector3(1f,1f,1f), 0.1f).setDelay(0.1f);
    }
    void top3Scale(){
        LeanTween.scale(highscoreItem[2], new Vector3(1.3f,1.3f, 0.5f), 0.1f);
        LeanTween.scale(highscoreItem[2], new Vector3(1f,1f,1f), 0.1f).setDelay(0.1f);

    }
    void openPanel(){
        panel.SetActive(true);
        LeanTween.alpha(panel.GetComponent<RectTransform>(), 0.9f, 0.5f);
    }
    void closePanel(){
        LeanTween.alpha(panel.GetComponent<RectTransform>(), 0f, 0.5f);
        Invoke("disablePanel",0.5f);
    }
    void disablePanel(){
        panel.SetActive(false);
    }

    
}
