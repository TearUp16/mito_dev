using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RadialProgressBar : MonoBehaviour
{
    
    [SerializeField] Image image;

    [SerializeField] float speed;

    float currentValue;

    void Update()
    {
        if (currentValue < 100)
        {
            currentValue += speed * Time.deltaTime;
            
        }     
        image.fillAmount = currentValue / 100;
    }
}
