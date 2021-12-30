using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1.0f;

    public void CompleteLevel ()
    {
        Debug.Log("VI VON");
    }

    public void EndGame ()
    {
        

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
        
        
    }
    void Restart ()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
}
