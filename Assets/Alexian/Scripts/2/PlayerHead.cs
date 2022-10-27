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
            if (transform.eulerAngles.z < 320 && transform.rotation.eulerAngles.z > 40)
            {
                end.Defeat();
            }
        }

        public void MoveLeft()
        {
            if (canMove == false)
            {
                return;
            }
            transform.eulerAngles += new Vector3(0, 0, 20);
        }

        public void MoveRight()
        {
            if (canMove == false)
            {
                return;
            }
            transform.eulerAngles += new Vector3(0, 0, -20);
        }

        public void Falling()
        {
            coin = Random.Range(1, 3);
            if(coin == 1)
            {
                MoveRight();
            }
            else
            {
                MoveLeft();
            }
        }
    }
}