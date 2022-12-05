using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class ColisionDefeat : MonoBehaviour
    {
        public EndScene loose;
        public PlayerHead move;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
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
                Debug.Log("Coucou");
                loose.Defeat();
            }
        }
    }
}
