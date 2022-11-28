using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Brandon
{
    public class Slap : MonoBehaviour
    {

        public Moustique moustique;
        public SpriteRenderer srMoustique;
        public Transform tapetteSlap;
        public Transform tapetteOmbreTransform;

        void Start()
        {
            
        }


        void Update()
        {
            
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(tapetteSlap.position.x == tapetteOmbreTransform.position.x)
            {
                Moustique moustiqueTriggered = collision.GetComponent<Moustique>();
                if (moustiqueTriggered != null)
                {
                
                    Destroy(moustique);

                }
            }
        }
    }
}
