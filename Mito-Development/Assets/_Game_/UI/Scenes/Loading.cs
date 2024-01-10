using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using JetBrains.Annotations;

public class Loading : MonoBehaviour
{
    float time, second;
    // Start is called before the first frame update
    void Start()
    {
        second = 5;
        Invoke("LoadGame", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (time < 5)
        {
            time += Time.deltaTime;
        }
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(2);
    }
}
