using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageManager : MonoBehaviour
{
    [SerializeField] GameObject completeText, pageChanger;
    [SerializeField] string loadPage;
    [SerializeField] int chapter, page;
    public void OnTextComplete(){
        completeText.SetActive(false);
        pageChanger.SetActive(true);
    }
    public void OnPageChange(){
        SceneManager.LoadScene(loadPage);
    }
    public void OnIntroPlayed(){
        if(chapter == 1 && page == 9){
            string introhasplayed = PlayerPrefs.GetString("IntroHasPlayed");
            if (introhasplayed == "false"){
                SceneManager.LoadScene("Play Scene");
                PlayerPrefs.SetString("IntroHasPlayed", "true");
                
            }else{
                OnPageChange();
            }
        }
    }
}
