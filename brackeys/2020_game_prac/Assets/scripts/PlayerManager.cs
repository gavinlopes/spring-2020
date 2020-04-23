﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    #region Singleton

    public static PlayerManager instance;
    
    
    

    void Awake()
    {
        instance = this;
    }
    
    #endregion

    public GameObject player;

    public void KillPlayer()
    {
        SceneManager.LoadScene("Game_final");
    }

    public void EndGame()
    {
            Debug.Log("DIED");        
    }


    

}
