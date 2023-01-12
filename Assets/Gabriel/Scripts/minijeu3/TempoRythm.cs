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
        public SpriteRenderer monPope;
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
                monPope.color = new Color(1f, 0.5f, 0.5f, 1);
                Invoke("PopeColor", 0.2f); ;
                IDchecker.errorCheck++;
                tempoState++;
            }
        }

        public void RythmCheck()
        {
            if (tempoState == 0)
            {
                if (IDchecker.rythmNumber == noteID)
                {
                    mr.material.color = Color.red;
                    IDchecker.errorCheck++;
                    monPope.color = new Color(1f, 0.5f, 0.5f, 1);
                    Invoke("PopeColor", 0.2f); ;
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

        public void PopeColor()
        {
            monPope.color = Color.white;
        }
    }
}
