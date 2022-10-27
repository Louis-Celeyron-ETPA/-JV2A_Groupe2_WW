using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace victor
{

    public class MOUVEMENTTEMPO : MonoBehaviour
    {
        public string keyUp;
        public string keyDown;
        public string keyRight;
        public string keyLeft;
        public KeyCode keyAction;
        public fonctionMove move;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(keyUp))
            {

                move.MoveUp();

            }

            if (Input.GetKey(keyDown))
            {
                 
                move.MoveDown();

            }

            if (Input.GetKey(keyRight))
            {

                move.MoveRight();

            }

            if (Input.GetKey(keyLeft))
            {

                move.MoveLeft();

            }

            if (Input.GetKey(keyAction))
            {

                move.Action();

            }
        }
    }


}
