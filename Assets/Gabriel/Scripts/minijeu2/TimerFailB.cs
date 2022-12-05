using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class TimerFailB : MonoBehaviour
    {
        public float timePass;
        public float timerMax;
        public RectTransform rt;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            timePass += Time.deltaTime;
            rt.sizeDelta = new Vector2((timerMax - timePass) * (100/timerMax), 100);
            if (timePass >= timerMax)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }
    }
}
