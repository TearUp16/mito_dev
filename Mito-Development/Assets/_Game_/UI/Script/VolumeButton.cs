using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class VolumeButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image _img;
    [SerializeField] private Sprite _default, _pressed, _muted, _mutedpressed;
    bool isMuted = false;
    AudioManager audioManager;
    private void Awake() {
        audioManager = GameObject.FindGameObjectsWithTag("Audio")[0].GetComponent<AudioManager>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
        if(isMuted){
            _img.sprite = _mutedpressed;
        }else{
            audioManager.PlaySFX(audioManager.buttonClick);
            _img.sprite = _pressed;
        }
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        if(isMuted){
            audioManager.PlaySFX(audioManager.buttonClick);
            _img.sprite = _default; 
            isMuted = false;
        }else{
            _img.sprite = _muted;
            isMuted = true;
        }
        
    }
}
