using  System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class Enemy : Interactable
{
    PlayerManager playermanger;
    CharacterStats myStats;

    void Start()
    {
        playermanger = PlayerManager.instance;
        myStats = GetComponent<CharacterStats>();
    }

    public override void Interact()
    {
        base.Interact();
        CharacterCombat playCombat = playermanger.player.GetComponent<CharacterCombat>();
        if (playCombat != null)
        {
            playCombat.Attack(myStats);
        }
    }

}
