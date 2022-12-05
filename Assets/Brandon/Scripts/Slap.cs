using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Brandon
{
    public class Slap : MonoBehaviour
    {

        public Moustique moustique;
        public Tapette tapette;
        public GameObject moustiqueObject;
        public Transform tapetteSlap;
        public Transform tapetteOmbreTransform;
        public Collider2D tapetteCollider;

        void Start()
        {
            
        }


        void Update()
        {
            
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if(tapetteSlap.position.x == tapetteOmbreTransform.position.x)
            {

                Moustique moustiqueTriggered = collision.GetComponent<Moustique>();
                if (moustiqueTriggered != null)
                {
                    
                    Destroy(moustiqueObject);
                    tapette.moustiqueKilled = true;

                }

                else
                {
                    tapette.gameOver = true;
                    Destroy(tapetteCollider);
                }
            }
        }
    }
}
