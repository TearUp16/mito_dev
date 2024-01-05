using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AnimButtonClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image _img;
    [SerializeField] private Sprite _default, _pressed;
    AudioManager audioManager;
    private void Awake() {
        audioManager = GameObject.FindGameObjectsWithTag("Audio")[0].GetComponent<AudioManager>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        _img.sprite = _pressed;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        _img.sprite = _default;
    }

    
}
