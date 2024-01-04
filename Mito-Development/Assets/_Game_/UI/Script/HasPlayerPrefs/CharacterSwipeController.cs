using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CharacterSwipeController : MonoBehaviour, IEndDragHandler
{
    // Start is called before the first frame update
    [SerializeField] int maxPage;
    int currentPage, questUnlock;
    Vector3 targetPos;
    [SerializeField] Vector3 pageStep;
    [SerializeField] RectTransform levelPagesRect;
    [SerializeField] LeanTweenType tweenType;
    [SerializeField] float tweenTime;
    float dragThreshold;
    [SerializeField] Image[] barImage;
    [SerializeField] Sprite aChar1, nChar1, aChar2, nChar2, aChar3, nChar3, aChar4, nChar4, aLockedBar, nLockedBar;
    
    [SerializeField] Button previousBtn, nextBtn;
    [SerializeField] Button[] selectBtn;
    [SerializeField] GameObject[] charselect;

    void Awake(){
        questUnlock = PlayerPrefs.GetInt("QuestUnlock");
        currentPage = 1;
        targetPos = levelPagesRect.localPosition;
        dragThreshold = Screen.width / 15;
        UpdatePos();
        UpdateArrowButton();
        foreach(var item in charselect){
            item.SetActive(false);
        }
        foreach(var item in selectBtn){
            item.interactable = false;
        }
        charselect[0].SetActive(true);
        selectBtn[0].interactable = true;
        
    }

    public void Next(){
        if(currentPage < maxPage){
            currentPage++;
            targetPos += pageStep;
            MovePage();

        }

    }

    public void Previous(){
        if(currentPage > 1 ){
            currentPage--;
            targetPos -= pageStep;
            MovePage();
        }
    }

    public void MovePage(){
        levelPagesRect.LeanMoveLocal(targetPos, tweenTime).setEase(tweenType);
        UpdatePos();
        UpdateArrowButton();
        setButtonActive();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if(Mathf.Abs(eventData.position.x - eventData.pressPosition.x) > dragThreshold){
            if(eventData.position.x > eventData.pressPosition.x) Previous();
            else Next();
        }
        else{
            MovePage();
        }
    }

    void UpdatePos(){
        DefaultState();
        SetActivePos();
    }
    void UpdateArrowButton(){
        nextBtn.interactable = true;
        previousBtn.interactable = true;
        if(currentPage==1) previousBtn.interactable = false;
        else if(currentPage == maxPage) nextBtn.interactable = false;
    }

    void DefaultState(){
        if(questUnlock >= 0){
            barImage[0].sprite = nChar1;
            barImage[1].sprite = nLockedBar;
            barImage[2].sprite = nLockedBar;
            barImage[3].sprite = nLockedBar;
        }
        UpdateDefaultCharBar();
        
    }
    void UpdateDefaultCharBar(){
        if(questUnlock >= 1){
             barImage[1].sprite = nChar2;
        }
        if(questUnlock >= 2){
             barImage[2].sprite = nChar3;
        }
        if(questUnlock >= 4){
             barImage[3].sprite = nChar4;
        }
    }
    void SetActivePos(){
        if(questUnlock >= 0){
            if(currentPage == 1) {
                barImage[0].sprite = aChar1;   
            }
            if(currentPage == 2) {
                barImage[1].sprite = aLockedBar;
                
            }
            if(currentPage == 3) {
                barImage[2].sprite = aLockedBar;
                
            }            
            if(currentPage == 4) {
                barImage[3].sprite = aLockedBar;
                
            }
        }
            UpdateActivePos();
    }

    void UpdateActivePos(){
        if(questUnlock >= 0){
            if(currentPage == 1) {
                barImage[0].sprite = aChar1;
                
            }
        }
        if(questUnlock >= 1){
            if(currentPage == 2) {
                barImage[1].sprite = aChar2;
                
            }
        }
        if(questUnlock >= 2){
            if(currentPage == 3) {
                barImage[2].sprite = aChar3;
                
            }
        }
        if(questUnlock >= 4){
            if(currentPage == 4) {
                barImage[3].sprite = aChar4;
                
            }
        }
    }


    void setButtonActive(){
        if(currentPage == 1){
            charselect[0].SetActive(true);
            charselect[1].SetActive(false);
            charselect[2].SetActive(false);
            charselect[3].SetActive(false);

            if(questUnlock >= 0){
                selectBtn[0].interactable = true;
            }
        }
        if(currentPage == 2){
            charselect[1].SetActive(true);
            charselect[0].SetActive(false);
            charselect[2].SetActive(false);
            charselect[3].SetActive(false);
            if(questUnlock >= 1){
                selectBtn[1].interactable = true;
            }
        }
        if(currentPage == 3){
            charselect[2].SetActive(true);
            charselect[0].SetActive(false);
            charselect[1].SetActive(false);
            charselect[3].SetActive(false);
            if(questUnlock >= 2){
                selectBtn[2].interactable = true;
            }
        }
        if(currentPage == 4){
            charselect[3].SetActive(true);
            charselect[0].SetActive(false);
            charselect[1].SetActive(false);
            charselect[2].SetActive(false);
            if(questUnlock >= 4){
                selectBtn[3].interactable = true;
            }
        }
    }
    
}
