using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gabriel
{
    public class TimerFailB : MonoBehaviour
    {
        public float timePass;
        public float timerMax;
        public Image img;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            timePass += Time.deltaTime;
            img.fillAmount = Mathf.Clamp(1 - (timePass / timerMax), 0, 1);
            if (timePass >= timerMax)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }
    }
}
