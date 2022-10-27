using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class PlayerHead : MonoBehaviour
    {
        public bool canMove;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void MoveLeft()
        {
            if (canMove == false)
            {
                return;
            }
            transform.eulerAngles = new Vector3(0, 1, 0);
        }

        public void MoveRight()
        {
            if (canMove == false)
            {
                return;
            }
            transform.eulerAngles = new Vector3(0, -1, 0);
        }
    }
}