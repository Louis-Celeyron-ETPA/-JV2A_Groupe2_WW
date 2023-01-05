using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alexian
{
    public class CursorRay : MonoBehaviour
    {
        public CensoredObject censoredObject;
        public RectTransform cursorPlayer;
        public RectTransform cursorClick;

        public TextMeshProUGUI text;
        public GameObject UI;
        public GameObject textUI;

        public float speed = 10f;
        public float widthBlur;
        public float heightBlur;
        public int count;

        public float currentTime;
        public bool gameEnd;
        public bool gameStarted;

        // Start is called before the first frame update
        void Start()
        {
            count = 8 + 2 * ManagerManager.DifficultyManager.GetDifficulty();
            if(count > 20)
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
            UI.SetActive(false);
            gameEnd = false;
            gameStarted = true;
            StartCoroutine(InGame());
        }
        public IEnumerator InGame()
        {
            while(gameStarted == false)
            {
                yield return new WaitForEndOfFrame();
            }
            yield return new WaitForSeconds(15);
            Defeat();
        }
        public void MoveUp()
        {
            cursorPlayer.position += cursorPlayer.up * speed;
        }
        public void MoveDown()
        {
            cursorPlayer.position -= cursorPlayer.up * speed;
        }
        public void MoveRight()
        {
            cursorPlayer.position += cursorPlayer.right * speed;
        }
        public void MoveLeft()
        {
            cursorPlayer.position -= cursorPlayer.right * speed;
        }
        public void click()
        {
            var xBlur = censoredObject.sizeBlur.position.x;
            var yBlur = censoredObject.sizeBlur.position.y;
            
            if((cursorClick.position.x >= xBlur || cursorClick.position.x+5 >= xBlur) && (cursorClick.position.x <= xBlur + widthBlur || cursorClick.position.x+5 <= xBlur + widthBlur))
            {
                if ((cursorClick.position.y >= yBlur || cursorClick.position.y+5 >= yBlur) && (cursorClick.position.y <= yBlur + heightBlur || cursorClick.position.y+5 <= yBlur + heightBlur) && count > 0)
                {
                    censoredObject.RandomBlur();
                    count -= 1;
                }
            }
        }

        public void Defeat()
        {
            if(gameEnd == false) 
            {
                gameEnd = true;
                UI.SetActive(true);
                textUI.SetActive(true);
                text.text = "Défaite";
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
            else
            {
                return;
            }
        }

        public void Victory()
        {
            if (gameEnd == false)
            {
                gameEnd = true;
                UI.SetActive(true);
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