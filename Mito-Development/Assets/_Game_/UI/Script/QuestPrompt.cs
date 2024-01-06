using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestPrompt : MonoBehaviour
{
    [SerializeField] GameObject questPrompt, ongoingQuestPrompt, historyQuestPrompt, infoPrompt1, infoPrompt2, infoPrompt3, infoPrompt4;

    AudioManager audioManager;
    private void Awake() {
        audioManager = GameObject.FindGameObjectsWithTag("Audio")[0].GetComponent<AudioManager>();
    }
    public void openQuest(){
        questPrompt.SetActive(true);
        ongoingQuest();
    }

    public void ongoingQuest(){
        audioManager.PlaySFX(audioManager.buttonClick);
        ongoingQuestPrompt.SetActive(true);
        historyQuestPrompt.SetActive(false);

    }
    public void historyQuest(){
        audioManager.PlaySFX(audioManager.buttonClick);
        historyQuestPrompt.SetActive(true);
        ongoingQuestPrompt.SetActive(false);
    }
    public void Close(){
        questPrompt.SetActive(false);
    }

    public void openInfo1(){
        audioManager.PlaySFX(audioManager.infoClick);
        infoPrompt1.SetActive(true);

    }
    public void openInfo2(){
        audioManager.PlaySFX(audioManager.infoClick);
        infoPrompt2.SetActive(true);
    }
    public void openInfo3(){
        audioManager.PlaySFX(audioManager.infoClick);
        infoPrompt3.SetActive(true);
    }
    public void openInfo4(){
        audioManager.PlaySFX(audioManager.infoClick);
        infoPrompt4.SetActive(true);
    }
    public void closeInfo1(){
        audioManager.PlaySFX(audioManager.closeClick);
        infoPrompt1.SetActive(false);
    }
    public void closeInfo2(){
        audioManager.PlaySFX(audioManager.closeClick);
        infoPrompt2.SetActive(false);
    }
    public void closeInfo3(){
        audioManager.PlaySFX(audioManager.closeClick);
        infoPrompt3.SetActive(false);
    }
    public void closeInfo4(){
        audioManager.PlaySFX(audioManager.closeClick);
        infoPrompt4.SetActive(false);
    }
}
