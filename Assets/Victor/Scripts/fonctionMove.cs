using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor {
    public class fonctionMove : MonoBehaviour
    {
        public Transform subject ;
        public Camera mainCamera;
        public targetValidation listfenetre;

        public  float speed = 10f;

        public bool inAction = false;


        // Start is called before the first frame update
        void Start()
        {
            mainCamera = Camera.main;
        }

        // Update is called once per frame
        void Update()
        {

            if(mainCamera.WorldToViewportPoint(transform.position).x> 1)
            {
                var tempVectorZero = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.farClipPlane));

                transform.position = new Vector3(tempVectorZero.x, transform.position.y, transform.position.z);
            }
            if (mainCamera.WorldToViewportPoint(transform.position).x < 0)
            {
                var tempVectorOne = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, mainCamera.farClipPlane));

                transform.position = new Vector3(tempVectorOne.x, transform.position.y, transform.position.z);
            }

            if (mainCamera.WorldToViewportPoint(transform.position).y > 1)
            {
                var tempVectorZero = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.farClipPlane));

                transform.position = new Vector3(transform.position.x, tempVectorZero.y, transform.position.z);
            }
            if (mainCamera.WorldToViewportPoint(transform.position).y < 0)
            {
                var tempVectorOne = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, mainCamera.farClipPlane));

                transform.position = new Vector3(transform.position.x, tempVectorOne.y, transform.position.z);
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
            if(listfenetre.isGood == true)
            {
                Debug.Log("Victoire");
            }
            if (listfenetre.isGood == false)
            {
                Debug.Log("Perdu");
            }
        }
      
    }
}
