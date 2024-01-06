using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UnlockStory : MonoBehaviour
{
    [SerializeField] Image[] playStory;
    AnimButtonClick animButtonClick;
    [SerializeField] EventTrigger[] eventTriggers;
    [SerializeField] Sprite lockedButton, unlockedButton;
    int questUnlock;
    void Awake(){
        questUnlock = PlayerPrefs.GetInt("QuestUnlock");
        if(questUnlock > 0){
            unlockStory();
        }else{
            lockStory();
        }
        
    }
    public void lockStory(){
        foreach(var item in playStory){
            item.sprite = lockedButton;
        }
        foreach(var item in eventTriggers){
            item.enabled = false;
            animButtonClick = item.GetComponent<AnimButtonClick>();
            animButtonClick.enabled = false;
        }
    }
    public void unlockStory(){
        if(questUnlock >= 1){
            playStory[0].sprite = unlockedButton ;
            eventTriggers[0].enabled = true;
             
        }
        if(questUnlock >= 2){
            playStory[1].sprite = unlockedButton ;
            eventTriggers[1].enabled = true;
             
        }
        if(questUnlock >= 3){
            playStory[2].sprite = unlockedButton ;
            eventTriggers[2].enabled = true;
        }
    }
}
