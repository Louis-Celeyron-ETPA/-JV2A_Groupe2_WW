using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class CreateTempo : MonoBehaviour
    {

        public float delaisTempo;
        public int timerTempo;
        private int noteNumber = 1;
        public CreateTempo self;

        public int rythmNumber = 0;

        public int variableTimer;

        public TempoRythm maNote;
        // Start is called before the first frame update
        void Start()
        {
            variableTimer = Random.Range(1, 3);
        }

        // Update is called once per frame
        void Update()
        {
            timerTempo++;

            if (timerTempo > variableTimer * delaisTempo)
            {
                variableTimer = Random.Range(1, 3);
                timerTempo = 0;

                TempoRythm noteTempo = Instantiate(maNote, new Vector3(10, 4, 14), Quaternion.identity);
                noteTempo.IDchecker = self;
                noteTempo.noteID = noteNumber;
                noteNumber++;
            }
        }

        public void rythmAugmentation()
        {
            rythmNumber++;
        }
    }
}
