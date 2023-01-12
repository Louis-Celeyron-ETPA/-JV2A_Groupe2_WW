using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Baptiste;

namespace Baptiste {
    public class Scene1Timing : MonoBehaviour
    {
        public class MailManReturn
        {
            public float timeA;
            public float timeB;
            public bool typeReturn;

            public MailManReturn(float newTimeA, float newTimeB, bool newTypeReturn)
            {
                timeA = newTimeA;
                timeB = newTimeB;
                typeReturn = newTypeReturn;
            }
        }

        public GameObject mailManFront;
        public GameObject mailManBack;
        public ThiccHandler myThiccHandler;
        public float currentTime;

        private int difficulty;
        private bool end;
        private Vector3 mailManHide;
        private Vector3 mailManShow;

        public List<MailManReturn> listReturn;

        // Start is called before the first frame update
        void Start()
        {
            difficulty = ManagerManager.DifficultyManager.GetDifficulty();
            listReturn = new List<MailManReturn>();
            end = false;

            mailManHide = new Vector3(22f, 1f, 0f);
            mailManShow = new Vector3(6f, 1f, -2f);

            listReturn.Add(new MailManReturn(1.42f, 2.34f, true));
            listReturn.Add(new MailManReturn(2.34f, 4.62f, false));
            listReturn.Add(new MailManReturn(4.62f, 5.48f, true));
            listReturn.Add(new MailManReturn(5.48f, 7.82f, false));
            listReturn.Add(new MailManReturn(7.82f, 8.6f, true));
            listReturn.Add(new MailManReturn(8.6f, 11f, false));
            listReturn.Add(new MailManReturn(11f, 11.8f, true));
            listReturn.Add(new MailManReturn(11.8f, 14.2f, false));
            listReturn.Add(new MailManReturn(14.2f, 14.6f, true));
            listReturn.Add(new MailManReturn(14.6f, 15f, false));
            listReturn.Add(new MailManReturn(15f, 15.4f, true));
            listReturn.Add(new MailManReturn(15.4f, 15.8f, false));
            listReturn.Add(new MailManReturn(15.8f, 16.2f, true));
            listReturn.Add(new MailManReturn(16.2f, 16.6f, false));
            listReturn.Add(new MailManReturn(16.6f, 17f, true));
            listReturn.Add(new MailManReturn(17f, 17.4f, false));
            listReturn.Add(new MailManReturn(17.4f, 17.8f, true));
            listReturn.Add(new MailManReturn(17.8f, 18.2f, false));
            listReturn.Add(new MailManReturn(18.2f, 18.6f, true));
            listReturn.Add(new MailManReturn(18.6f, 19f, false));
            listReturn.Add(new MailManReturn(19f, 19.4f, true));
            listReturn.Add(new MailManReturn(19.4f, 19.8f, false));
            listReturn.Add(new MailManReturn(19.8f, 20.2f, true));
            listReturn.Add(new MailManReturn(20.2f, 20.6f, false));
            listReturn.Add(new MailManReturn(20.6f, 21f, true));
            listReturn.Add(new MailManReturn(21f, 21.4f, false));
            listReturn.Add(new MailManReturn(21.4f, 21.8f, true));
            listReturn.Add(new MailManReturn(21.8f, 22.2f, false));
            listReturn.Add(new MailManReturn(22.2f, 22.6f, true));
            listReturn.Add(new MailManReturn(22.6f, 23f, false));
            listReturn.Add(new MailManReturn(23f, 23.4f, true));
            listReturn.Add(new MailManReturn(23.4f, 23.8f, false));
            listReturn.Add(new MailManReturn(23.8f, 24.2f, true));
            listReturn.Add(new MailManReturn(24.2f, 24.6f, false));
            listReturn.Add(new MailManReturn(24.6f, 25f, true));
            listReturn.Add(new MailManReturn(25f, 25.4f, false));
            listReturn.Add(new MailManReturn(25.4f, 25.8f, true));
            listReturn.Add(new MailManReturn(25.8f, 26.2f, false));
            listReturn.Add(new MailManReturn(26.2f, 25.6f, true));
            listReturn.Add(new MailManReturn(26.6f, 27f, false));
        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;

            foreach (MailManReturn item in listReturn)
            {
                if (currentTime > item.timeA && currentTime < item.timeB)
                {
                    if (item.typeReturn)
                    {
                        mailManBack.transform.position = mailManShow;
                        mailManFront.transform.position = mailManHide;
                    }
                    else
                    {
                        mailManBack.transform.position = mailManHide;
                        mailManFront.transform.position = mailManShow;
                    }
                }

            }

            if (currentTime > 27 && !end)
            {
                if (difficulty == 1)
                {
                    if (myThiccHandler.score < 0)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                    }
                    else if (myThiccHandler.score > 3000)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
                    }
                    else
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                    }
                }
                else if (difficulty == 2)
                {
                    if (myThiccHandler.score < 1500)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                    }
                    else if (myThiccHandler.score > 3000)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
                    }
                    else
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                    }
                }
                else
                {
                    if (myThiccHandler.score < 3000)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                    }
                    else
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
                    }
                }
                end = true;
            }
        }
    }
}
