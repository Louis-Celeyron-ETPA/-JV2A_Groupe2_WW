using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
    public class BalloonCollector : MonoBehaviour
    {
        public BalloonManager balloonManager;
        public GameObject Balloon;
        
        [SerializeField] AudioSource popSound;

        private void Start()
        {
            balloonManager = FindObjectOfType<BalloonManager>(); // detect Object type
            
            popSound = GetComponent<AudioSource>(); //detect audio source
        }

        //private void OnMouseDown()
        //{

            //Destroy(gameObject);
            //balloonManager.OnBalloonPop(gameObject.tag);
            //popSound.Play();

        //}

    }

}
