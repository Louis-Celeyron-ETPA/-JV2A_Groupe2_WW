using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class TempoRythm : MonoBehaviour
    {

        public float vitesseRythm;
        public int tempoState;
        public MeshRenderer mr;
        public int noteID;

        public CreateTempo IDchecker;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.position += Vector3.left * vitesseRythm;

            if (tempoState == 2)
            {
                mr.material.color = Color.red;
                IDchecker.rythmNumber++;
                tempoState++;
            }
        }

        public void RythmCheck()
        {
            if (tempoState == 0)
            {
                Debug.Log(IDchecker.rythmNumber);
                Debug.Log(noteID);
                if (IDchecker.rythmNumber == noteID)
                {
                    mr.material.color = Color.red;
                    tempoState = 3;
                }
            }
            else if (tempoState == 1)
            {
                if ((mr.material.color != Color.red) && (IDchecker.rythmNumber == noteID))
                {
                    mr.enabled = false;
                    tempoState = 3;
                }
            }
        }
    }
}
