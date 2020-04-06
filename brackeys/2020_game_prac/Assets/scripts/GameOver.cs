using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private bool gameEnded = false;
    
    

    private void Update()
    {
        if (gameEnded)
            return;

        if (CharacterStats <- 0 )
        {
            EndGame();
        }
    }

    public int CharacterStats { get; set; }

    void EndGame()
    {
        gameEnded = true;
        Debug.Log("Game Over!");
    }
}
