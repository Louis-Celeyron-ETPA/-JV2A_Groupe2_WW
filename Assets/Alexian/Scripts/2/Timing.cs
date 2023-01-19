using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alexian
{
    public class Timing : MonoBehaviour
    {
        public FakeMove lampie;
        public PlayerHead headFalling;
        public EndScene end;
        public GameObject UI;

        public float timeMax;
        public bool gameStarted = false;

        void Start()
        {
            StartCoroutine(Launch());
        }

        void Update()
        {
            if (end.gameEnd == true)
            {
                return;
            }
        }

        public IEnumerator Launch()
        {
            for (int i = 1; i < 4; i++)
            {
                yield return new WaitForSeconds(1);
                end.text.text = i.ToString();
            }
            yield return new WaitForSeconds(1);
            end.text.text = "Reste debout !";
            yield return new WaitForSeconds(1);
            UI.SetActive(false);
            end.gameEnd = false;
            gameStarted = true;
            headFalling.canMove = true;
            StartCoroutine(InGame());
            StartCoroutine(LampNew());
        }

        public IEnumerator LampNew()
        {
            while (gameStarted == false)
            {
                yield return new WaitForEndOfFrame();
            }
            while(end.gameEnd == false)
            {
                var switchTime = ManagerManager.DifficultyManager.GetDifficulty();
                if(ManagerManager.DifficultyManager.GetDifficulty() > 4)
                {
                    switchTime = 4;
                }
                yield return new WaitForSeconds(timeMax - switchTime);
                lampie.lampCreate();
                headFalling.Falling();
            }
        }

        public IEnumerator InGame()
        {
            while (gameStarted == false)
            {
                yield return new WaitForEndOfFrame();
            }
            yield return new WaitForSeconds(20);
            end.Victory();
        }
    }
}