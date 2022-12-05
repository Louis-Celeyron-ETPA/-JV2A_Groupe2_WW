using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian{
    public class EnnemyInitialD : MonoBehaviour
    {
        public Transform player;
        public Transform ennemy;
        public bool canMove;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (canMove == false)
            {
                return;
            }

            ennemy.position += Vector3.up * (0.035f + 0.02f * ManagerManager.DifficultyManager.GetDifficulty());

            if (player.position.y >= 15 || ennemy.position.y >= 15)
            {
                canMove = false;
            }
        }
    }
}