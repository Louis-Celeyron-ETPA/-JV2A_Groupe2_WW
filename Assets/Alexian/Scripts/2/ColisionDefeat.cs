using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class ColisionDefeat : MonoBehaviour
    {
        public EndScene end;
        public PlayerHead move;

        void Start()
        {

        }

        void Update()
        {

        }
        private void OnTriggerEnter(Collider other)
        {

            if (move.canMove == false)
            {
                return;
            }
            if (other.gameObject.tag == "Finish")
            {
                end.Defeat();
            }
        }
    }
}
