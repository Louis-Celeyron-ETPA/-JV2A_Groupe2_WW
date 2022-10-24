using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class TEMPOTOUCHES2 : MonoBehaviour
    {
        public PlayerHead player;
        public float difficulty = 1f;
        public float leftBouton;
        public float rightBouton;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.S) == true)
            {
                player.MoveLeft();
            }
            if (Input.GetKeyDown(KeyCode.S) == true)
            {
                player.MoveRight();
            }
        }
    }
}