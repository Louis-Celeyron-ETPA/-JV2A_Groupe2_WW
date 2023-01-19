using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Alexian
{
    public class Player : MonoBehaviour
    {
        public Transform player;
        public Transform ennemy;
        public Ending end;

        public bool canMove;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (player.position.y >= 15 || ennemy.position.y >= 15)
            {
                canMove = false;
                end.EndGame();
            }
        }

        public void Move()
        {
            if (canMove == false)
            {
                return;
            }
            player.position += Vector3.up * 0.5f;
        }
    }
}