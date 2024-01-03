using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockQuest : MonoBehaviour
{
    int questUnlock, questProgress1, questProgress2, questProgress3, questProgress4;
    [SerializeField] GameObject[] questItem, questItemDone, questRewardChar, questRewardStory;


    void Awake()
    {
        questUnlock = 0;//PlayerPrefs.GetInt("QuestUnlock");
        PlayerPrefs.SetInt("QuestUnlock", questUnlock);
        unlockNewQuest();
    }
    public void unlockNewQuest(){
        if(questUnlock == 0){
            questItem[0].SetActive(true);

            questItemDone[4].SetActive(true);
        }
        else if(questUnlock == 1){
            questItem[1].SetActive(true);
            Destroy(questItem[0]);

            questItemDone[0].SetActive(true);
            Destroy(questItemDone[4]);
        }
        else if(questUnlock == 2){
            questItem[2].SetActive(true);
            Destroy(questItem[0]);
            Destroy(questItem[1]);

            questItemDone[0].SetActive(true);
            questItemDone[1].SetActive(true);
        }
        else if(questUnlock == 3){
            questItem[3].SetActive(true);
            Destroy(questItem[0]);
            Destroy(questItem[1]);
            Destroy(questItem[2]);

            questItemDone[0].SetActive(true);
            questItemDone[1].SetActive(true);
            questItemDone[2].SetActive(true);
        }
        else if(questUnlock > 4){
            questItem[4].SetActive(true);
            Destroy(questItem[0]);
            Destroy(questItem[1]);
            Destroy(questItem[2]);
            Destroy(questItem[3]);

            questItemDone[0].SetActive(true);
            questItemDone[1].SetActive(true);
            questItemDone[2].SetActive(true);
            questItemDone[3].SetActive(true);
        }
    }
    public void QuestComplete(){
        if(questUnlock == 0){
            UnlockQuestReward0();
            questUnlock++;
            PlayerPrefs.SetInt("QuestUnlock", questUnlock);
        }else if(questProgress1 == 25){
            UnlockQuestReward1();
            questUnlock++;
            PlayerPrefs.SetInt("QuestUnlock", questUnlock);
        }else if(questProgress2 == 40){
            UnlockQuestReward2();
            questUnlock++;
            PlayerPrefs.SetInt("QuestUnlock", questUnlock);         
        }else if(questProgress3 == 60){
            UnlockQuestReward3();      
            questUnlock++;
            PlayerPrefs.SetInt("QuestUnlock", questUnlock);  
        }else if(questProgress4 == 2000){
            UnlockQuestReward4();
            questUnlock++;
            PlayerPrefs.SetInt("QuestUnlock", questUnlock);       
        }
    }
    void UnlockQuestReward0(){
        questRewardChar[0].SetActive(true);
        questRewardStory[0].SetActive(true);

    }
    void UnlockQuestReward1(){
        questRewardChar[1].SetActive(true);
        questRewardStory[1].SetActive(true);

    }
    void UnlockQuestReward2(){
        questRewardChar[2].SetActive(true);
        questRewardStory[2].SetActive(true);
    }
    void UnlockQuestReward3(){
        questRewardStory[3].SetActive(true);
    }
    void UnlockQuestReward4(){
        questRewardChar[3].SetActive(true);

    }
    
}
