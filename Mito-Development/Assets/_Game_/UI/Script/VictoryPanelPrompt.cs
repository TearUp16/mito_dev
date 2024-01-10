using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryPanelPrompt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void BackToHome(){
        SceneManager.LoadScene("Title Screen Main");
    }
}
