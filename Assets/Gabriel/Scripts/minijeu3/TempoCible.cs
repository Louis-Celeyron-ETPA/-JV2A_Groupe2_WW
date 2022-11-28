using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class TempoCible : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            TempoRythm monTempo = other.GetComponent<TempoRythm>();

            if (monTempo != null)
            {
                if (monTempo.tempoState != 3)
                {
                    monTempo.tempoState = 1;
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            TempoRythm monTempo = other.GetComponent<TempoRythm>();

            if (monTempo.tempoState != 3)
            {
                monTempo.tempoState = 2;
            }
        }
    }
}
