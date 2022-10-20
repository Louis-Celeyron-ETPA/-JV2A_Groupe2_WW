using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian{
    public class EnnemyInitialD : MonoBehaviour
    {
        public Transform player;
        public Transform ennemy;
        public bool canMove;
        public TEMPOTOUCHES difficulty;
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

            ennemy.position += Vector3.up * (0.055f * difficulty.difficulty);

            if (player.position.y >= 15 || ennemy.position.y >= 15)
            {
                canMove = false;
            }
        }
    }
}