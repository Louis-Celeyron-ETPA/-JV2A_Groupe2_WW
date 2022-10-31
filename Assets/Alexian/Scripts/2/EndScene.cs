using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alexian {
    public class EndScene : MonoBehaviour
    {
        public PlayerHead canMove;
        public bool gameEnd = true;
        public float gameTime;
        public TextMeshProUGUI text;
        public GameObject UI;
        private bool isShowing;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (gameEnd == true)
            {
                return;
            }
            gameTime += Time.deltaTime;
            if (gameTime >= 20)
            {
                Victory();
            }
        }

        public void Defeat()
        {
            gameEnd = true;
            canMove.canMove = false;
            isShowing = true;
            UI.SetActive(isShowing);
            text.text = "Défaite";
        }

        public void Victory()
        {
            gameEnd = true;
            canMove.canMove = false;
            isShowing = true;
            UI.SetActive(isShowing);
            text.text = "Victoire";
        }
    }
}