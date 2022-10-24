using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class TEMPOTOUCHES : MonoBehaviour
    {
        public Player player;
        public bool actionButton;
        public float difficulty = 1f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                player.Move();
            }
        }
    }
}