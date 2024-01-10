using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreTransition : MonoBehaviour
{
    int currentScore;
    [SerializeField] int targetScore;
    [SerializeField] GameObject transition;
    [SerializeField]string Scene;
     private void Awake() {
        
    }
    private void Start() {
        EnableTransition();
         Invoke("NextScene", 1f);
    }
    
    public void EnableTransition(){
        transition.SetActive(true);
        LeanTween.reset();
        LeanTween.alpha(transition.GetComponent<RectTransform>(), 1f, 0.5f).setDelay(0.5f);
    }
    public void NextScene(){
        SceneManager.LoadScene(Scene);
    }


}
