using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{

    public class ItemCollector : MonoBehaviour
    {
        public BalloonManager balloonManager;
        public BalloonSpawner balloonSpawner;
        public GameObject Balloon;
        
        [SerializeField] AudioSource popSound;

        private void Start()
        {
            balloonManager = FindObjectOfType<BalloonManager>(); // detect Object type
            balloonSpawner = FindObjectOfType<BalloonSpawner>();
            popSound = GetComponent<AudioSource>(); //detect audio source
        }

        private void OnMouseDown()
        {

            Destroy(gameObject);
            balloonManager.OnBalloonPop(gameObject.tag);
            popSound.Play();

        }

        // Find instance randomizer for balloons //

        /*
            var joystick = new Joystick(directInput, joystickGuid);
            Console.WriteLine("Found Joystick/Gamepad with GUID: {0}", joystickGuid);
            var allEffects = joystick.GetEffects();
            foreach (var effectInfo in allEffects)
            Console.WriteLine("Effect available {0}", effectInfo.Name);
         */

    }

}
