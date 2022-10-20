using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor {
    public class fonctionMove : MonoBehaviour
    {
        public  Transform subject ;

        public  float speed = 1f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

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
        public void Action()
        {

        }
    }
}
