using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

namespace Osborne
{

    public class BalloonCursorMouvement : MonoBehaviour
    {

        private GameObject myBalloon;
        public BalloonManager balloonManager;

        [SerializeField] AudioSource popSound;
        [SerializeField] float speed = 1f;

    // Update is called once per frame
        void Update()
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);

            var myRay = new Ray(transform.position, Vector3.forward);
            if (Physics.Raycast(myRay, out var other))
            {
                if (other.collider.GetComponent<BalloonCollector>() != null)
                {
                    myBalloon = other.collider.GetComponent<Transform>().gameObject;
                }
                else
                {
                    myBalloon = null;
                }
            }
        }

        public void BalloonHit()
        {
            if (myBalloon != null)
            {
                Destroy(myBalloon);
                balloonManager.OnBalloonPop(gameObject.tag);
                //popSound.Play();
            }

            
            /*if (myBalloon = 0)
            {
                ManagerManager.LifeManager.GetCurrentLife();
            }*/
        }

    }

}
