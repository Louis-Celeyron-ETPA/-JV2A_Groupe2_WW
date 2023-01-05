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
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(Launch());
        }

        // Update is called once per frame
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
                yield return new WaitForSeconds(timeMax - ManagerManager.DifficultyManager.GetDifficulty());
                lampie.lampCreate();
                headFalling.Falling();
            }
        }
    }
}