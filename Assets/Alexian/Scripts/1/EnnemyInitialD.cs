using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian{
    public class EnnemyInitialD : MonoBehaviour
    {
        public Transform player;
        public Transform ennemy;

        public bool canMove;

        private float speed;
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
            speed = 0.01f + 0.015f * ManagerManager.DifficultyManager.GetDifficulty();
            if(speed > 0.075f)
            {
                speed = 0.075f;
            }
            ennemy.position += Vector3.up * speed;
            

            if (player.position.y >= 15 || ennemy.position.y >= 15)
            {
                canMove = false;
            }
        }
    }
}