using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class CensoredObject : MonoBehaviour
    {
        public RectTransform sizeBlur;
        public RectTransform rtImage;
        public CursorRay cursor;


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

            cursor.widthBlur = widthCensor;
            cursor.heightBlur = heightCensor;

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
            return rtImage.rect.Contains(rect.min) && rtImage.rect.Contains(rect.max);
        }
    }
}