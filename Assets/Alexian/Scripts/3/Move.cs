using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class Move : MonoBehaviour
    {
        public RectTransform cursorPlayer;
        public CensoredObject censoredObject;
        public RectTransform cursorClick;
        public Game game;

        public float widthBlur;
        public float heightBlur;

        private float speed = 10f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void MoveUp()
        {
            if (game.gameStarted == false)
            {
                return;
            }
            cursorPlayer.position += cursorPlayer.up * speed;
        }
        public void MoveDown()
        {
            if (game.gameStarted == false)
            {
                return;
            }
            cursorPlayer.position -= cursorPlayer.up * speed;
        }
        public void MoveRight()
        {
            if (game.gameStarted == false)
            {
                return;
            }
            cursorPlayer.position += cursorPlayer.right * speed;
        }
        public void MoveLeft()
        {
            if (game.gameStarted == false)
            {
                return;
            }
            cursorPlayer.position -= cursorPlayer.right * speed;
        }
        public void click()
        {
            if (game.gameStarted == false)
            {
                return;
            }
            var xBlur = censoredObject.sizeBlur.position.x;
            var yBlur = censoredObject.sizeBlur.position.y;

            if ((cursorClick.position.x >= xBlur || cursorClick.position.x + 5 >= xBlur) && (cursorClick.position.x <= xBlur + widthBlur || cursorClick.position.x + 5 <= xBlur + widthBlur))
            {
                if ((cursorClick.position.y >= yBlur || cursorClick.position.y + 5 >= yBlur) && (cursorClick.position.y <= yBlur + heightBlur || cursorClick.position.y + 5 <= yBlur + heightBlur) && game.count > 0)
                {
                    censoredObject.RandomBlur();
                    game.count -= 1;
                }
            }
        }
    }
}