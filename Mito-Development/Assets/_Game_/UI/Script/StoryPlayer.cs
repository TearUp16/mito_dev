using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryPlayer : MonoBehaviour
{
    [SerializeField] string ch1, ch2, ch3, ch4;
    public void Chapter1(){
        SceneManager.LoadScene(ch1);
    }
    public void Chapter2(){
        SceneManager.LoadScene(ch2);
    }
    public void Chapter3(){
        SceneManager.LoadScene(ch3);
    }
    public void Chapter4(){
        SceneManager.LoadScene(ch4);
    }
}
