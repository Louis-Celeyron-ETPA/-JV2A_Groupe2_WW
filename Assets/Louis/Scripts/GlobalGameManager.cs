using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalGameManager : MonoBehaviour
{
    public int MinigamesFinished;
    
    public void WinGame()
    {
        Debug.Log("C'est perdu");
    }

    public void LoseGame()
    {
        Debug.Log("C'est gagné");
    }
}
