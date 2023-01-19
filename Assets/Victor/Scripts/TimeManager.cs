using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace victor
{
    public class TimeManager : MonoBehaviour
    {

        public float currentTime;
        public float timeStart;
        public float timeMax;


        public GameObject mainActor;
        public GameObject UI;
        public GameObject textUI;
        public GameObject ecranUI;
        public TextMeshProUGUI text;

        public bool isActive;

        public string miniJeu;

        // Start is called before the first frame update
        void Start()
        {

            timeMax = timeMax / ManagerManager.DifficultyManager.GetDifficulty(); //augmente a chaque tour de miniJeu

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
            if (currentTime > 4)
            {
                text.text = miniJeu;
            }
            if (currentTime >= timeMax)
            {
                textUI.SetActive(true);
                ecranUI.SetActive(true);
                isActive = true;

                text.text = "Perdu!!!";
            }

        }
    }

}

