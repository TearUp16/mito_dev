
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using JetBrains.Annotations;

public class CharacterSelect : MonoBehaviour
{
    [SerializeField] TMP_Text[] label;
    string selectedChar; 
    string apolaki, amanikable, anituntabu, mayari;
    AudioManager audioManager;
    private void Awake() {
        audioManager = GameObject.FindGameObjectsWithTag("Audio")[0].GetComponent<AudioManager>();
    }
    void Start(){
        RetrieveSelected();
        
    }

    public void selectApolaki(){
        audioManager.PlaySFX(audioManager.selectClick);
        Deselect();
        apolaki = "Apolaki";
        label[0].SetText("selected");
        SetCharacter(apolaki);
    }
    public void selectAmanikable(){
        audioManager.PlaySFX(audioManager.selectClick);
        Deselect();
        amanikable = "Amanikable";
        label[1].SetText("selected");
        SetCharacter(amanikable);
        
    }
    public void selectAnitunTabu(){
        audioManager.PlaySFX(audioManager.selectClick);
        Deselect();
        anituntabu = "Anituntabu";
        label[2].SetText("selected");
        SetCharacter(anituntabu);
    }
    public void selectMayari(){
        audioManager.PlaySFX(audioManager.selectClick);
        Deselect();
        mayari = "Mayari";
        label[3].SetText("selected");
        SetCharacter(mayari);
    }

    
    void SetCharacter(string charac){
        PlayerPrefs.SetString("CharacterSelected", charac);
        PlayerPrefs.Save();
    }

    void Deselect(){
        foreach(var item in label){
            item.SetText("select");
        }
    }
    void RetrieveSelected(){
        selectedChar = PlayerPrefs.GetString("CharacterSelected");
        if(selectedChar == "Apolaki"){
            label[0].SetText("selected");
        }
        if(selectedChar == "Amanikable"){
            label[1].SetText("selected");
        }
        if(selectedChar == "Anituntabu"){
            label[2].SetText("selected");
        }
        if(selectedChar == "Mayari"){
            label[3].SetText("selected");
        }
    }
    
}
