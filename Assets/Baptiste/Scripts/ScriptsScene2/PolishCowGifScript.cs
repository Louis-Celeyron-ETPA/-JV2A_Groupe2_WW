using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Baptiste;

namespace Baptiste
{
    public class PolishCowGifScript : MonoBehaviour
    {

        public float Delay = 0.1f;
        public Material[] Materials;
        public Renderer TargetRenderer;
        private int _currentIndex = 0;
        private float _elapsedTime = 0;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            _elapsedTime += Time.deltaTime;
            if (_elapsedTime <= Delay)
            {
                return;
            }
            _elapsedTime = 0;
            _currentIndex++;
            if (_currentIndex >= Materials.Length)
            {
                _currentIndex = 0;
            }
            TargetRenderer.material = Materials[_currentIndex];
        }
    }
}

