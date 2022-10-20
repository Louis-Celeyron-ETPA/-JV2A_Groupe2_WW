using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class Timing : MonoBehaviour
    {
        public float currentTime;
        public float timeMax;
        public FakeMove lampie;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;
            if (currentTime >= timeMax)
            {
                lampie.lampCreate();
                currentTime = 0;
            }
        }
    }
}