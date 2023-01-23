using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
    public class PaddleGoal : MonoBehaviour
    {
        public bool score;
        public Rigidbody myRigidbody;

        public bool isGood = false;

        private void Start()
        {
            myRigidbody = GetComponent<Rigidbody>();
        }

        void OnTriggerEnter(Collider triggerCollider)
        {
            if (triggerCollider.tag == "Ball")
            {
                Destroy(triggerCollider.gameObject);
                if (isGood == true)
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                }
                else
                {
                    Debug.Log("Failed");
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                    ManagerManager.LifeManager.GetCurrentLife();
                    ManagerManager.DifficultyManager.GetDifficulty();
                }
            }
        }
    }

}