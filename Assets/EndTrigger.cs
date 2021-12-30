using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Game_Manager gameManager;

    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
