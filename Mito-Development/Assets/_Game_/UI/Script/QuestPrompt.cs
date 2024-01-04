using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestPrompt : MonoBehaviour
{
    [SerializeField] GameObject questPrompt, ongoingQuestPrompt, historyQuestPrompt, infoPrompt1, infoPrompt2, infoPrompt3, infoPrompt4;


    public void openQuest(){
        questPrompt.SetActive(true);
        ongoingQuest();
    }

    public void ongoingQuest(){
        ongoingQuestPrompt.SetActive(true);
        historyQuestPrompt.SetActive(false);

    }
    public void historyQuest(){
        historyQuestPrompt.SetActive(true);
        ongoingQuestPrompt.SetActive(false);
    }
    public void Close(){
        questPrompt.SetActive(false);
    }

    public void openInfo1(){
        infoPrompt1.SetActive(true);

    }
    public void openInfo2(){
        infoPrompt2.SetActive(true);
    }
    public void openInfo3(){
        infoPrompt3.SetActive(true);
    }
    public void openInfo4(){
        infoPrompt4.SetActive(true);
    }
    public void closeInfo1(){
        infoPrompt1.SetActive(false);
    }
    public void closeInfo2(){
        infoPrompt2.SetActive(false);
    }
    public void closeInfo3(){
        infoPrompt3.SetActive(false);
    }
    public void closeInfo4(){
        infoPrompt4.SetActive(false);
    }
}
