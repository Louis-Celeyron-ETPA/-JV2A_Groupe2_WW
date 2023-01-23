using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quentin
{


public class DifficultyGameOne : MonoBehaviour
{
        // Start is called before the first frame update
        public MovePoint myMovePoint;
        //int difficulty = ManagerManager.DifficultyManager.GetDifficulty();
        int difficulty = 3;
    void Start()
    {
            if (difficulty == 1)
            {
                myMovePoint.speed = myMovePoint.speed * 1.5f;
            }

            else if (difficulty == 2)
            {
                myMovePoint.speed = myMovePoint.speed *1;
            }

            else if (difficulty == 3)
            {
                myMovePoint.speed = myMovePoint.speed / 2;
            }
        }

    
}
}