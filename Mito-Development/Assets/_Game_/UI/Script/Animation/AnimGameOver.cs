using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimGameOver : MonoBehaviour
{
    [SerializeField] GameObject[] gameOverComponent;

    private void Start() {
        LeanTween.reset();
        float delay = 0.1f;
        for(int i = 0; i < gameOverComponent.Length; i++){
            LeanTween.scale(gameOverComponent[i], new Vector3(1f,1f,1f),0.5f).setEase(LeanTweenType.easeInOutElastic).setDelay(delay);
            delay += 0.1f;
        }
        
    }
}
