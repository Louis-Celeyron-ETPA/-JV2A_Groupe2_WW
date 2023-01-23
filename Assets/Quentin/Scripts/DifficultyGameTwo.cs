using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyGameTwo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myGarlicFinder;
    //int difficulty = ManagerManager.DifficultyManager.GetDifficulty();
    int difficulty = 3;
    void Start()
    {
        if (difficulty == 1)
        {


           myGarlicFinder.transform.localScale += new Vector3(3, 3, 0);
        }

        if (difficulty == 2)
        {


            myGarlicFinder.transform.localScale += new Vector3(2.5f, 2.5f, 0);
        }

        if (difficulty == 3)
        {


            myGarlicFinder.transform.localScale += new Vector3(-1.5f, -1.5f, 0);
        }


    }
}
