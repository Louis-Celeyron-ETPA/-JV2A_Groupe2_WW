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
            Debug.Log(sizeBlur.rect);
        }

        public void RandomBlur()
        {
            var widthImage = rtImage.rect.width;
            var heightImage = rtImage.rect.height;

            var widthCensor = Random.Range(0, widthImage);
            var heightCensor = Random.Range(0, heightImage);

            var xPosition = Random.Range(-widthImage/2, widthImage/2);
            var yPosition = Random.Range(-heightImage/2, heightImage/2);

            while (IsRectInRect(new Rect(xPosition, yPosition,widthCensor,heightCensor)) == false)
            {
                xPosition = Random.Range(-widthImage / 2, widthImage / 2);
                yPosition = Random.Range(-heightImage / 2, heightImage / 2);
            }

            sizeBlur.sizeDelta = new Vector2(widthCensor, heightCensor);
            sizeBlur.anchoredPosition = new Vector2(xPosition, yPosition);

        }

        private bool IsRectInRect(Rect rect)
        {
            Debug.Log("Rect 1" + rect);
            Debug.Log("Rect 2" + rtImage.rect);
            return rtImage.rect.Contains(rect.min) && rtImage.rect.Contains(rect.max);
        }
    }
}