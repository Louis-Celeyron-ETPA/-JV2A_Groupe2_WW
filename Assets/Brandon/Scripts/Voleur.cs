using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Brandon
{
    public class Voleur : MonoBehaviour
    {

        public Transform myTransform;
        public Light spotVoleur;
        public float speed = 0.1f;
        public float descendingSpeed = 0.05f;
        public int direction;
        public bool gameOver = false;
        public bool descending = false;
        public bool catching = false;


        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (!gameOver)
            {
                if (!descending && !catching)
                {
                    myTransform.position += myTransform.right * speed * direction;
                }

                else if (descending)
                {
                    myTransform.position -= myTransform.up * descendingSpeed;
         
                }
                else if (catching)
                {
                    myTransform.position += myTransform.up * descendingSpeed;
                }
            }

            else
            {
                spotVoleur.enabled = true;
            }
            
            

        }



    }
}