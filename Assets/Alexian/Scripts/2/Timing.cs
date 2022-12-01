using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alexian
{
    public class Timing : MonoBehaviour
    {
        public float currentTime;
        public float timeMax;
        public FakeMove lampie;
        public PlayerHead headFalling;
        public EndScene end;
        public TEMPOTOUCHES2 difficulty;
        public SpriteRenderer sr;
        public GameObject UI;
        private bool isShowing;
        public PlayerHead canMove;
        public bool gameStarted = false;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (end.gameEnd == true)
            {
                return;
            }

            if (gameStarted == false)
            {
                currentTime += Time.deltaTime;
                if (currentTime >= 5)
                {
                    sr.enabled = false;
                    canMove.canMove = true;
                    isShowing = false;
                    UI.SetActive(isShowing);
                    end.gameEnd = false;
                    currentTime = 0;
                    gameStarted = true;
                }
                currentTime += Time.deltaTime;
                if (currentTime > 1)
                {
                    end.text.text = "1";
                }
                if (currentTime > 2)
                {
                    end.text.text = "2";
                }
                if (currentTime > 3)
                {
                    end.text.text = "3";
                }
                if (currentTime > 4)
                {
                    end.text.text = "Reste debout !";
                }
            }

            if(gameStarted == true)
            {
                currentTime += Time.deltaTime;
                if (currentTime >= (timeMax - difficulty.difficulty))
                {
                    lampie.lampCreate();
                    headFalling.Falling();
                    currentTime = 0;
                }
            }
        }
    }
}