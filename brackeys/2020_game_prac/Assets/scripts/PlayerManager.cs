using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    #region Singleton

    public static PlayerManager instance;
    private bool gameEnd = false;
    public float restartDelay = 1f;
    
    

    void Awake()
    {
        instance = this;
    }
    
    #endregion

    public GameObject player;

    public void KillPlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void EndGame()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("DIED");
            Invoke("Restart", restartDelay);
        }      
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    

}
