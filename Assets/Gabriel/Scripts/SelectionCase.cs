using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class SelectionCase : MonoBehaviour
    {

        public ListeLettre mesCases;
        public int positionCurseur;
        public int currentLettre = 0;

        private bool didRightInput, didLeftInput;
        // Start is called before the first frame update
        void Start()
        {
            transform.position = new Vector3(-8f, 5f, -10f);
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void ValideCase()
        {
            if (currentLettre <= mesCases.nombreLettre - 1)
            {
                if (mesCases.couleurLettre[currentLettre] == positionCurseur)
                {
                    mesCases.listeDesLettres[currentLettre].mr.enabled = false;
                    currentLettre++;
                }
            }
        }

        public void CaseGauche()
        {
            if(didLeftInput == false)
            {
                positionCurseur -= 1;
                if (positionCurseur < 0) { positionCurseur = 3; }
                didLeftInput = true;
                transform.position = new Vector3(-8f + (positionCurseur) * 5f, 5f, -10f);
            }
        }

        public void CaseDroite()
        {
            if(didRightInput == false)
            {
                positionCurseur += 1;
                if (positionCurseur > 3) { positionCurseur = 0; }
                didRightInput = true;
                transform.position = new Vector3(-8f + (positionCurseur) * 5f, 5f, -10f);
            }
        }

        public void ResetInput()
        {
            didLeftInput = false;
            didRightInput = false;
        }
    }
}

