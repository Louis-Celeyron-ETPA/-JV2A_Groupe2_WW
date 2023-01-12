using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class PlayerHead : MonoBehaviour
    {
        public EndScene end;

        public int coin;
        public bool canMove;
        public bool right;
        public bool left;

        void Start()
        {

        }

        void Update()
        {

        }

        public void MoveLeft()
        {
            if (canMove == false)
            {
                return;
            }
            left = true;
        }

        public void MoveRight()
        {
            if (canMove == false)
            {
                return;
            }
            right = true;
        }

        public void Falling()
        {
            coin = Random.Range(1, 3);
            if(coin == 1)
            {
                right = true;
                MoveReset();
            }
            else
            {
                left = true;
                MoveReset();
            }
        }

        public void MoveReset()
        {
            if(left == true && right == false)
            {
                transform.eulerAngles += new Vector3(0, 0, 20);
                right = false;
                left = false;
            }
            if (right == true && left == false)
            {
                transform.eulerAngles += new Vector3(0, 0, -20);
                left = false;
                right = false;
            }
        }
    }
}