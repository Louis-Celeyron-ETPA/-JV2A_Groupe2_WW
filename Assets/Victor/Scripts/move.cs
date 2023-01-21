using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor
{
    public class Move : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody rB;

        [SerializeField]
        private Transform subject;

        [SerializeField]
        private TimeManagerV time;

        [SerializeField]
        private float speed = 0.001f;
        private float distanceRay = 1f;

        // Start is called before the first frame update
        void Start()
        {
            speed = speed * (ManagerManager.DifficultyManager.GetDifficulty()*0.5f);

        }

        // Update is called once per frame
        void Update()
        {
            if (time.canMove == true)
            {
                rB.useGravity = false;
            }
            else
            {
                rB.useGravity = true;
            }
            //Debug.DrawRay(subject.position, Vector3.down);
            if (Physics.Raycast(subject.position, Vector3.down, out var info, distanceRay))
            {
                var ground = info.transform.GetComponent<Pool>();

                if (ground != null)
                {
                    time.isWin = true;
                }
                else
                {
                    time.isLoose = true;
                }
                
            }
        }
        public void MoveRight()
        {
            subject.position += subject.right * speed;
            if (Physics.Raycast(subject.position, Vector3.down, distanceRay))
            {
                speed = 0;
            }
        }
        public void MoveLeft()
        {
            subject.position -= subject.right * speed;
            if (Physics.Raycast(subject.position, Vector3.down, distanceRay))
            {
                speed = 0;
            }
        }



    }
}
