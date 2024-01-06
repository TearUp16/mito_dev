using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialSkill : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject specialSkillPrefab;

    //ige-get yung animation component ng player para mapalitan kapag priness yung button
    [SerializeField]
    private GameObject player;

    //for the special skill, we'll need the gameobject of the player, and the animation that happens when
    // the player uses its special skill. after that, it will be triggered at button press and the animation will play.

}
