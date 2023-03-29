using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    PlayerBase player;

    void Start()
    {
        player = FindObjectOfType<PlayerBase>();
        player.Speak();
        Debug.Log(player.GetType());
    }

}
