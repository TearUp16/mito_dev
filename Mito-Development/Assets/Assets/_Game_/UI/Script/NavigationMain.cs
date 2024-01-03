using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NavigationMain : MonoBehaviour
{
    public void OnHomeClick(){
        SceneManager.LoadScene("Title Screen Main");
    }

    public void OnPlayClick(){

        SceneManager.LoadScene("Play Scene");
        //SceneManager.LoadScene("Story");
    }

    public void OnStartGame()
    {
        SceneManager.LoadScene("Apolaki");
    }

    public void OnHeroesClick(){
        SceneManager.LoadScene("Heroes Scene");
    }
    public void OnStoryClick(){
        SceneManager.LoadScene("Story Scene");
    }
    public void OnLeaderBoardsClick(){
        SceneManager.LoadScene("Leaderboard");
    }
    
    public void OnHelpClick(){
        SceneManager.LoadScene("Help Scene");
    }
    
}
