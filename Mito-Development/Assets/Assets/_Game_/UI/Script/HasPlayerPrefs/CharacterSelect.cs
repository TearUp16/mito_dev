
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
    void Start(){
        RetrieveSelected();
        
    }

    public void selectApolaki(){
        Deselect();
        apolaki = "Apolaki";
        label[0].SetText("selected");
        SetCharacter(apolaki);
    }
    public void selectAmanikable(){
        Deselect();
        amanikable = "Amanikable";
        label[1].SetText("selected");
        SetCharacter(amanikable);
        
    }
    public void selectAnitunTabu(){
        Deselect();
        anituntabu = "Anituntabu";
        label[2].SetText("selected");
        SetCharacter(anituntabu);
    }
    public void selectMayari(){
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
