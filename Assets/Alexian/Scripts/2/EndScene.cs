using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alexian {
    public class EndScene : MonoBehaviour
    {
        public TextMeshProUGUI text;
        public GameObject UI;
        public PlayerHead move;

        public bool gameEnd = true;
        

        void Start()
        {
            
        }

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
            move.canMove = false;
            UI.SetActive(true);
            text.text = "Défaite";
            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
        }

        public void Victory()
        {
            gameEnd = true;
            move.canMove = false;
            UI.SetActive(true);
            text.text = "Victoire";
            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
        }
    }
}