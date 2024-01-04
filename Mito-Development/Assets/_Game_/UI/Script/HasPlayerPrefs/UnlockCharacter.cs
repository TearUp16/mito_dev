using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockCharacter : MonoBehaviour
{
    int questUnlock;
    [SerializeField] GameObject[] character_unlocked;
    [SerializeField] GameObject[] character_locked;

    void Awake()
    {
        questUnlock = PlayerPrefs.GetInt("QuestUnlock");
        
        unlockCharacter();
    }
    void unlockCharacter(){
        if(questUnlock >= 1){
            character_locked[1].SetActive(false);
            character_unlocked[1].SetActive(true);
            Destroy(character_locked[1]);
        }
        if(questUnlock >= 2){
            character_locked[2].SetActive(false);
            character_unlocked[2].SetActive(true);
            Destroy(character_locked[2]);
        }
        if(questUnlock >= 4){
            character_locked[3].SetActive(false);
            character_unlocked[3].SetActive(true);
            Destroy(character_locked[3]);
        }
    }
}
