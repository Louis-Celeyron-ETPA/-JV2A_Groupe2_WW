using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace osborne
{

    public class HexagonTimer : MonoBehaviour
    {
        // Start is called before the first frame update
        public float timeRemaining = 30;
        public bool timeIsRunning = false;
        public TextMeshProUGUI timeText;


        private void Start()
        {
            timeIsRunning = true;
        }

        void Update()
        {
            if (timeIsRunning == true)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                }
            }
            DisplayTime(timeRemaining);

            if (timeIsRunning == true)
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


        void DisplayTime(float timeToDisplay)
        {
            //timeToDisplay += 1;
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);
            timeText.text = string.Format("{0:00}", seconds);

        }

    }

}