using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alexian
{
    public class Game : MonoBehaviour
    {
        public TextMeshProUGUI text;
        public GameObject ui;
        public GameObject textUI;

        public int count;
        public bool gameStarted;

        private bool gameEnd;

        // Start is called before the first frame update
        void Start()
        {
            count = 8 + 2 * ManagerManager.DifficultyManager.GetDifficulty();
            if (count > 20)
            {
                count = 20;
            }
            StartCoroutine(Launch());
        }

        // Update is called once per frame
        void Update()
        {
            if (count == 0)
            {
                Victory();
            }
        }
        public IEnumerator Launch()
        {
            for (int i = 1; i < 4; i++)
            {
                yield return new WaitForSeconds(1);
                text.text = i.ToString();
            }
            yield return new WaitForSeconds(1);
            text.text = "Retire !";
            yield return new WaitForSeconds(1);
            textUI.SetActive(false);
            ui.SetActive(false);
            gameEnd = false;
            gameStarted = true;
            StartCoroutine(InGame());
        }
        public IEnumerator InGame()
        {
            while (gameStarted == false)
            {
                yield return new WaitForEndOfFrame();
            }
            yield return new WaitForSeconds(15);
            Defeat();
        }

        private void Defeat()
        {
            if (gameEnd == false)
            {
                gameEnd = true;
                ui.SetActive(true);
                textUI.SetActive(true);
                text.text = "Défaite";
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
            else
            {
                return;
            }
        }

        private void Victory()
        {
            if (gameEnd == false)
            {
                gameEnd = true;
                ui.SetActive(true);
                textUI.SetActive(true);
                text.text = "Victoire";
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            else
            {
                return;
            }
        }
    }
}