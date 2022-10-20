using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{

    public class ItemCollector : MonoBehaviour
    {
        public BaloonManager baloonManager;
        public GameObject Balloon;
        [SerializeField] AudioSource popSound;

        private void Start()
        {
            baloonManager = FindObjectOfType<BaloonManager>(); // detect Object type
            popSound = GetComponent<AudioSource>(); //detect audio source
        }

        private void OnMouseDown()
        {

            Destroy(gameObject);
            baloonManager.OnBaloonPop(gameObject.tag);
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
