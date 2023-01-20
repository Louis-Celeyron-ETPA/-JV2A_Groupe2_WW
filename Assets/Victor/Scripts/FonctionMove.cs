using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace victor
{
    public class FonctionMove : MonoBehaviour
    {
        public RectTransform subject;
        public Camera mainCamera;
        public TimeManagerV time;


        private float speed = 10f;

        public int windowShoot;

        [SerializeField]
        private GenerateWindow Window;

        [SerializeField]
        private TimeManagerV timer;

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

            //Debug.Log(positionTemporaire); 

            if (positionTemporaire.x > 1 )
            {
                subject.anchoredPosition = new Vector3(0, subject.anchoredPosition.y);
            }
            if (positionTemporaire.x < 0 )
            {
                subject.anchoredPosition = new Vector3(mainCamera.pixelWidth, subject.anchoredPosition.y);
            }
            if (positionTemporaire.y > 1 )
            {
                subject.anchoredPosition = new Vector3(subject.anchoredPosition.x, 0);
            }
            if (positionTemporaire.y < 0 )
            {
                subject.anchoredPosition = new Vector3(subject.anchoredPosition.x, -mainCamera.pixelHeight);
            }

        }

        public void MoveUp()
        {
            if(time.isActive == false)
            {
                subject.position += subject.up * speed;
            }
            
        }
        public void MoveDown()
        {
            if (time.isActive == false)
            {
                subject.position -= subject.up * speed;
            }
        }
        public void MoveRight()
        {
            if (time.isActive == false)
            {
                subject.position += subject.right * speed;
            }
        }
        public void MoveLeft()
        {
            if (time.isActive == false)
            {
                subject.position -= subject.right * speed;
            }
        }
        public void Action()
        {
            if (time.isActive == false)
            {
                Debug.Log("action");
                var rectTransform = (transform as RectTransform);
                var positionTemporaire = new Vector3(
                    rectTransform.anchoredPosition.x / Camera.main.pixelWidth,
                    1 + rectTransform.anchoredPosition.y / Camera.main.pixelHeight,
                    Camera.main.nearClipPlane);
                var convertedPosition = Camera.main.ViewportToWorldPoint(positionTemporaire);
                var positionDansLeMonde = new Vector3(convertedPosition.x, convertedPosition.y, convertedPosition.z);
                Debug.Log(positionDansLeMonde);

                Debug.DrawRay(positionDansLeMonde, Camera.main.transform.forward * 12);
                if (Physics.Raycast(positionDansLeMonde, Camera.main.transform.forward, out var info))
                {
                    var censoredWindow = info.transform.GetComponent<TargetValidation>();

                    if (censoredWindow != null)
                    {
                        if (censoredWindow.isGood == true)
                        {
                            censoredWindow.isGood = false;
                            windowShoot += 1;
                            Debug.Log(windowShoot);

                        }
                        else
                        {
                            Debug.Log("raté");
                            timer.isLose = true;
                        }
                    }
                }
            }
            
        }
    }
}
