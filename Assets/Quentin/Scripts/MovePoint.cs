using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Quentin
{
    public class MovePoint : MonoBehaviour


    {
        // Start is called before the first frame update
        public Transform MyTransform;
        public float speed = 0.9f;

        private void Start()
        {
            



        }
        public void MoveUp()
        {
            MyTransform.position += MyTransform.up * speed / 2;
        }
        public void MoveLeft()
        {
            MyTransform.position -= MyTransform.right * speed / 2;
        }
        public void MoveDown()
        {
            MyTransform.position -= MyTransform.up * speed / 2;
        }
        public void MoveRight()
        {
            MyTransform.position += MyTransform.right * speed / 2;
        }


        private void Update()
        {


        }
    }
}