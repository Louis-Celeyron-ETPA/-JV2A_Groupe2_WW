using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace osborne
{

    public class HexagonTimer : MonoBehaviour
    {
        // Start is called before the first frame update
        public float timeRemaining = 20;
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
        }


        void DisplayTime(float timeToDisplay)
        {
            //timeToDisplay += 1;
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);
            timeText.text = string.Format("{0:00}", seconds);

        }

    }

}