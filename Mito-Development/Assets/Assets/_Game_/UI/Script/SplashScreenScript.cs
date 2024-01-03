using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenScript : MonoBehaviour
{
    [SerializeField] string loadNextScene;

    public void Load(){
        SceneManager.LoadScene(loadNextScene);
    }
    
}
