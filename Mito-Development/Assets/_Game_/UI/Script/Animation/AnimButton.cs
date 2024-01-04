using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimButton : MonoBehaviour
{
    Button btn;
    Vector3 upscale = new Vector3(1.2f,1.2f, 1);
    void Awake(){
        btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Anim);
    }
    void Anim(){
        LeanTween.scale(gameObject, upscale, 0.1f);
        LeanTween.scale(gameObject, Vector3.one, 0.1f).setDelay(0.1f);
    }
}
