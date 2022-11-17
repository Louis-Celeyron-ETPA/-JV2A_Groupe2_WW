using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor
{
    public class fonctionMove : MonoBehaviour
    {
        public RectTransform subject;
        public Camera mainCamera;
        public targetValidation listfenetre;

        public float speed = 10f;

        public bool inAction = false;

        private Vector3 positionTemporaire;


        // Start is called before the first frame update
        void Start()
        {
            mainCamera = Camera.main;
            subject = transform as RectTransform;
        }

        // Update is called once per frame
        void Update()
        {
            var rectTransform = (transform as RectTransform);
            positionTemporaire = new Vector3(
                rectTransform.anchoredPosition.x / Camera.main.pixelWidth,
                rectTransform.anchoredPosition.y / Camera.main.pixelHeight * -1,
                Camera.main.nearClipPlane);

            if (positionTemporaire.x > 1)
            {
                subject.anchoredPosition = new Vector3(0, subject.anchoredPosition.y);
            }
            if (positionTemporaire.x < 0)
            {
                subject.anchoredPosition = new Vector3(mainCamera.pixelWidth, subject.anchoredPosition.y);
            }
            if (positionTemporaire.y > 1)
            {
                subject.anchoredPosition = new Vector3(subject.anchoredPosition.x, 0);
            }
            if (positionTemporaire.y < 0)
            {
                subject.anchoredPosition = new Vector3(subject.anchoredPosition.x, -mainCamera.pixelHeight);
            }

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
            var rectTransform = (transform as RectTransform);
            var positionTemporaire = new Vector3(
                rectTransform.anchoredPosition.x / Camera.main.pixelWidth,
                rectTransform.anchoredPosition.y / Camera.main.pixelHeight * -1,
                Camera.main.nearClipPlane);
            var convertedPosition = Camera.main.ViewportToWorldPoint(positionTemporaire);

            var positionDansLeMonde = new Vector3(convertedPosition.x, -convertedPosition.y, convertedPosition.z);

            if (Physics.Raycast(positionDansLeMonde, Camera.main.transform.forward, out var info))
            {
                var censoredWindow = info.transform.GetComponent<targetValidation>();

                if (censoredWindow != null)
                {
                    if (censoredWindow.isGood == true)
                    {
                        Debug.Log("bien jouer FDP");
                    }
                    else
                    {
                        Debug.Log("perdu");
                    }
                }
            }
        }
    }
}
