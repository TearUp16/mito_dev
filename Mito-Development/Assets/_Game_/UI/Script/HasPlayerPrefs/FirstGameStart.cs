using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FirstGameStart : MonoBehaviour
{   [SerializeField] Image[] buttons;
    [SerializeField] Sprite heroesButton, storyButton, questButton, leaderboardsButton, dheroesButton, dstoryButton, dquestButton, dleaderboardsButton;
    [SerializeField] EventTrigger[] eventTriggers;
    AnimButtonClick animButtonClick;

    string hasplayed; 

    public void Awake()
    {
        hasplayed = PlayerPrefs.GetString("PlayerHasPlayed");
        
        if(hasplayed == "true"){
            SetButtonsEnable();
        }else{
            SetButtonsDisable();
        }
        
    

    }
    void SetButtonsDisable(){
        buttons[0].sprite = dheroesButton;
        buttons[1].sprite = dstoryButton;
        buttons[2].sprite = dquestButton;
        buttons[3].sprite = dleaderboardsButton;
        foreach(var item in eventTriggers){
            item.enabled = false;
            animButtonClick = item.GetComponent<AnimButtonClick>();
            animButtonClick.enabled = false;
        }
    }
    void SetButtonsEnable(){
        buttons[0].sprite = heroesButton;
        buttons[1].sprite = storyButton;
        buttons[2].sprite = questButton;
        buttons[3].sprite = leaderboardsButton;
        foreach(var item in eventTriggers){
            item.enabled = true;
            animButtonClick = item.GetComponent<AnimButtonClick>();
            animButtonClick.enabled = true;
        }
    }
}
