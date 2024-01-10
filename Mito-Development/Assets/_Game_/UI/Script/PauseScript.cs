using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] string Scene;
    

    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart(){
        SceneManager.LoadScene(Scene);
        pauseMenu.SetActive(false);
        Time.timeScale = 1;

    }
    public void GoToSettings(){
        SceneManager.LoadScene("Settings Scene");
        Time.timeScale = 1;
    }
    public void QuitToMenu(){
        pauseMenu.SetActive(false);
        SceneManager.LoadScene("Title Screen Main");
        Time.timeScale = 1;
    }
}
