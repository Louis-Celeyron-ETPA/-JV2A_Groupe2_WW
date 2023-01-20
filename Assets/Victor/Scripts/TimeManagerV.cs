using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace victor
{
    public class TimeManagerV : MonoBehaviour
    {

        private float currentTime;
        private float timeStart;

        [SerializeField]
        private float timeMax;

        [SerializeField]
        private GameObject UI;

        [SerializeField]
        private GameObject textUI;

        [SerializeField]
        private GameObject ecranUI;

        [SerializeField]
        private TextMeshProUGUI text;

        [SerializeField]
        private FonctionMove target;

        [SerializeField]
        private GenerateWindow window;

        [SerializeField]
        private string miniJeu;

        public bool isActive;
        public bool isWin = false;
        public bool isLose = false;


        // Start is called before the first frame update
        void Start()
        {

            timeMax = timeMax / ManagerManager.DifficultyManager.GetDifficulty(); //the time max diminish at with Difficulty

        }


        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;
            if (currentTime >= timeStart)
            {
                textUI.SetActive(false);
                ecranUI.SetActive(false);
                isActive = false;
            }
            if (currentTime > 1)
            {
                text.text = "3";
            }
            if (currentTime > 2)
            {
                text.text = "2";
            }
            if (currentTime > 3)
            {
                text.text = "1";
            }
            if (currentTime > 5)
            {
                text.text = miniJeu;
            }
            if (currentTime >= timeMax)
            {
                isLose = true;
            }

            if (target.windowShoot == window.nombreBonneFenetre)
            {
                isWin = true;
                Debug.Log(window.nombreBonneFenetre);
            }
            if (isLose == true)
            {
                textUI.SetActive(true);
                ecranUI.SetActive(true);
                isActive = true;

                text.text = "Perdu!!!";
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
            if (isWin == true)
            {
                textUI.SetActive(true);
                ecranUI.SetActive(true);
                isActive = true;

                text.text = "Victoir!!!";
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }





        }
    }

}

