using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class LampMove : MonoBehaviour
    {
        public Transform lamp;
        public EndScene end;
        public Timing timing;

        private float lampSpeed = 0.4f;


        void Start()
        {

        }

        void Update()
        { 
            if (end.gameEnd == true || timing.gameStarted == false)
            {
                return;
            }
            var speed = Vector3.back * lampSpeed * ManagerManager.DifficultyManager.GetDifficulty();
            if(ManagerManager.DifficultyManager.GetDifficulty() > 4)
            {
                speed = Vector3.back * lampSpeed * 4;
            }
            lamp.position += speed;
        }

        public void FakeLampMove() 
        {
            if (end.gameEnd == true)
            {
                return;
            }
            var speed = Vector3.back * lampSpeed * ManagerManager.DifficultyManager.GetDifficulty();
            if (ManagerManager.DifficultyManager.GetDifficulty() > 4)
            {
                speed = Vector3.back * lampSpeed * 4;
            }
            transform.position += speed;
        }
    }
}