using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class Music : MonoBehaviour
    {
        public AudioSource audios;
        // Start is called before the first frame update
        void Start()
        {
            audios.PlayDelayed(2);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}