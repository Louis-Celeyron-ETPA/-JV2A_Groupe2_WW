using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class PlayerHead : MonoBehaviour
    {
        public bool canMove;
        public int coin;
        public EndScene end;
        public bool right;
        public bool left;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(end.gameEnd == true)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
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
            if(right == true && left == false)
            {
                transform.eulerAngles += new Vector3(0, 0, 20);
                right = false;
                left = false;
            }
            if (left == true && right == false)
            {
                transform.eulerAngles += new Vector3(0, 0, -20);
                left = false;
                right = false;
            }
        }
    }
}