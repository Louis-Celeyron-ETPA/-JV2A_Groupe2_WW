using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alexian {
    public class EndScene : MonoBehaviour
    {
        public TextMeshProUGUI text;
        public GameObject UI;
        public PlayerHead canMove;

        public bool gameEnd = true;
        public Timing timing;

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(InGame());
        }

        // Update is called once per frame
        void Update()
        {
            if (gameEnd == true)
            {
                return;
            }
        }

        public void Defeat()
        {
            gameEnd = true;
            canMove.canMove = false;
            UI.SetActive(true);
            text.text = "Défaite";
            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
        }

        public void Victory()
        {
            gameEnd = true;
            canMove.canMove = false;
            UI.SetActive(true);
            text.text = "Victoire";
            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
        }

        public IEnumerator InGame()
        {
            while (timing.gameStarted == false)
            {
                yield return new WaitForEndOfFrame();
            }
            yield return new WaitForSeconds(20);
            Victory();
        }
    }
}