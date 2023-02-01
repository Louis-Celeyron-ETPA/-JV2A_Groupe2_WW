using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Brandon
{

    public class Tapette : MonoBehaviour
    {

        public Transform tapetteTransform;
        public Transform tapetteOmbreTransform;
        public SpriteRenderer tapetteOmbre;
        public Transform tapetteSlap;
        public Rigidbody2D rgbd;
        public bool slap = false;
        public bool upArrow = false;
        public bool downArrow = false;
        public bool leftArrow = false;
        public bool rightArrow = false;
        public float speed = 0.5f;
        public float slapSpeed = 0.7f;
        public bool gameOver = false;
        public bool moustiqueKilled = false;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (!gameOver)
            {

                if (leftArrow && tapetteSlap.position.x != tapetteOmbreTransform.position.x)
                {
                    //tapetteTransform.position -= tapetteTransform.right * speed;
                    rgbd.MovePosition(tapetteTransform.position+tapetteTransform.right * -speed);
                    leftArrow = false;
                    
                }

                if (rightArrow && tapetteSlap.position.x != tapetteOmbreTransform.position.x)
                {
                    //tapetteTransform.position += tapetteTransform.right * speed;
                    rgbd.MovePosition(tapetteTransform.position + tapetteTransform.right * speed);
                    rightArrow = false;

                }

                if (upArrow && tapetteSlap.position.x != tapetteOmbreTransform.position.x)
                {
                    //tapetteTransform.position += tapetteTransform.up * speed;
                    rgbd.MovePosition(tapetteTransform.position + tapetteTransform.up * speed);
                    upArrow = false;

                }

                if (downArrow && tapetteSlap.position.x != tapetteOmbreTransform.position.x)
                {
                    //tapetteTransform.position -= tapetteTransform.up * speed;
                    rgbd.MovePosition(tapetteTransform.position + tapetteTransform.up * -speed);
                    downArrow = false;

                }

                if (slap)
                {
                    tapetteSlap.position = Vector2.MoveTowards(tapetteSlap.position, tapetteOmbreTransform.position, slapSpeed);
                    if(tapetteSlap.position.x == tapetteOmbreTransform.position.x)
                    {
                        tapetteOmbre.enabled = false;
                    }
                }

                if (moustiqueKilled)
                {
                    gameOver = true;
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                }

            }
            
        }

        public void Slap()
        {
            tapetteSlap.position = Vector2.MoveTowards(tapetteSlap.position, tapetteOmbreTransform.position, slapSpeed);
            if (tapetteSlap.position.x == tapetteOmbreTransform.position.x)
            {
                tapetteOmbre.enabled = false;
            }
        }

    }

}

