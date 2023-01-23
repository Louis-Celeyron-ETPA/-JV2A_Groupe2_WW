using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Brandon
{
    public class Treasure : MonoBehaviour
    {
        public Voleur voleur;
        public Transform treasure;
        public float treasureSpeed = 0.05f;

        void Update()
        {
            if (voleur.catching)
            {
                treasure.position += treasure.up * treasureSpeed;
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Voleur voleurTriggered = collision.GetComponent<Voleur>();
            if (voleurTriggered != null)
            {
                voleur.catching = true;
                voleur.descending = false;
                
            }

        }

        
    }
}

