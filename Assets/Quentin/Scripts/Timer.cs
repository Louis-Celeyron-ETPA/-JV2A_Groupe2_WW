using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Quentin
{
    public class Timer : MonoBehaviour
    {
        // Start is called before the first frame update
        float time;
        public float speed = 0.5f;
        public Transform targetTransform;
        public Vector3 direction;

        public bool isStart;
        private bool shouldGo = false;
        public Timer next;


        void Start()
        {
            if (isStart)
            {
                Go();
            }

        }

        // Update is called once per frame
        void Update()
        {

            if (shouldGo)
            {
                time += Time.deltaTime;
                transform.position += direction * speed;
                if (time >= 0.7)
                {
                    if (next != null)
                    {
                        next.Go();
                    }
                    shouldGo = false;
                }
            }
        }

        void Go()
        {
            direction = (targetTransform.position - transform.position).normalized;
            shouldGo = true;
        }
    }
}
