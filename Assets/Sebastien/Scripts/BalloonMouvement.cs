using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
    public class BalloonMouvement : MonoBehaviour
    {
        [SerializeField] float speed = 1f;

        public Transform subject;

        // Update is called once per frame
        void Update()
        {
           // transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);
        }

        public void MoveUp()
        {
            subject.position += subject.up * speed;
        }
        public void MoveDown()
        {
            subject.position -= subject.up * speed;
        }
        public void MoveRight()
        {
            subject.position += subject.right * speed;
        }
        public void MoveLeft()
        {
            subject.position -= subject.right * speed;
        }


        }

}
