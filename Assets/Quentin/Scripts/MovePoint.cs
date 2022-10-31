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

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKey(KeyCode.Z))
            {
                MyTransform.position += MyTransform.up * speed / 2;
            }
            if (Input.GetKey(KeyCode.Q))
            {
                MyTransform.position -= MyTransform.right * speed / 2;
            }
            if (Input.GetKey(KeyCode.S))
            {
                MyTransform.position -= MyTransform.up * speed / 2;
            }
            if (Input.GetKey(KeyCode.D))
            {
                MyTransform.position += MyTransform.right * speed / 2;
            }


            if (Input.GetKeyDown(KeyCode.Space))
            {
                speed = speed / 4;
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                speed = speed * 4;
            }



        }
    }
}