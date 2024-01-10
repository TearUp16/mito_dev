using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    

    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart(){
        SceneManager.LoadScene("Apolaki");
        Time.timeScale = 1;

    }
    public void GoToSettings(){
        SceneManager.LoadScene("Settings Scene");
        Time.timeScale = 1;
    }
    public void QuitToMenu(){
        SceneManager.LoadScene("Title Screen Main");
        Time.timeScale = 1;
    }
}
