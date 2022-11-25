using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Brandon
{

    public class Tapette : MonoBehaviour
    {

        public Transform tapetteTransform;
        public bool slap = false;
        public bool upArrow = false;
        public bool downArrow = false;
        public bool leftArrow = false;
        public bool rightArrow = false;
        public float speed = 0.5f;
        public bool gameOver = false;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (!gameOver)
            {

                if (leftArrow)
                {
                    tapetteTransform.position -= tapetteTransform.right * speed;
                    
                }

                if (rightArrow)
                {
                    tapetteTransform.position += tapetteTransform.right * speed;
                   
                }

                if (upArrow)
                {
                    tapetteTransform.position += tapetteTransform.up * speed;
                   
                }

                if (downArrow)
                {
                    tapetteTransform.position -= tapetteTransform.up * speed;
               
                }

            }
            
        }
    }

}

