using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class CursorRay : MonoBehaviour
    {
        public CensoredObject censoredObject;
        public RectTransform cursorPlayer;
        public RectTransform cursorClick;
        public float speed = 10f;
        public float widthBlur;
        public float heightBlur;
        public int count;
        public float currentTime;

        // Start is called before the first frame update
        void Start()
        {
            count = 8 + 2 * ManagerManager.DifficultyManager.GetDifficulty();
            if(count > 20)
            {
                count = 20;
            }
        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;
            if (count == 0)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            else if(currentTime >= 15)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
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
    }
}