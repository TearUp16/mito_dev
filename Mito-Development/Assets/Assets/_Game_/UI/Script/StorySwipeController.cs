using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StorySwipeController : MonoBehaviour, IEndDragHandler
{
    // Start is called before the first frame update
    [SerializeField] int maxPage;
    int currentPage;
    Vector3 targetPos;
    [SerializeField] Vector3 pageStep;
    [SerializeField] RectTransform levelPagesRect;
    [SerializeField] LeanTweenType tweenType;
    [SerializeField] float tweenTime;
    float dragThreshold;
    [SerializeField] Image[] barImage;
    [SerializeField] Sprite active, notActive;
    [SerializeField] Button previousBtn, nextBtn;

    public void Awake(){
        currentPage = 1;
        targetPos = levelPagesRect.localPosition;
        dragThreshold = Screen.width / 15;
        UpdatePos();
        UpdateArrowButton();

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
        foreach(var item in barImage){
            item.sprite = notActive;
        }
        barImage[currentPage - 1].sprite = active;
    }

    void UpdateArrowButton(){
        nextBtn.interactable = true;
        previousBtn.interactable = true;
        if(currentPage==1) previousBtn.interactable = false;
        else if(currentPage == maxPage) nextBtn.interactable = false;
    }
    
    
}
