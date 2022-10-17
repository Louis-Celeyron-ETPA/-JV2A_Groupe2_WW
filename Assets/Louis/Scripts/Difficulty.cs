using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public static Difficulty Instance;
    private void Awake()
    {
        if(Difficulty.Instance != null)
        {
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this);
    }

    private int currentDifficulty = 1;
    public void RiseDifficulty()
    {
        currentDifficulty++;
    }
    public void DowngradeDifficulty()
    {
        currentDifficulty--;
    }
    public int GetDifficulty()
    {
        return currentDifficulty;
    }
}
