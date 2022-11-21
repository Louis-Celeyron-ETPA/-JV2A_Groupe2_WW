using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class CensoredObject : MonoBehaviour
    {
        public Transform positionObject;
        public RectTransform sizeBlur;
        public bool isMoving;
        public bool firstClick;
        public RectTransform rtImage;
        // Start is called before the first frame update
        void Start()
        {
            RandomBlur();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void RandomBlur()
        {
            var widthImage = rtImage.rect.width;
            var heightImage = rtImage.rect.height;

            var widthCensor = Random.Range(0, widthImage);
            var heightCensor = Random.Range(0, heightImage);

            sizeBlur.sizeDelta = new Vector2(widthCensor, heightCensor);
        }
    }
}