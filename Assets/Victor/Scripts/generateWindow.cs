using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;
namespace victor
{
    
    public class generateWindow : MonoBehaviour {

        public targetValidation maFenetre;
        public List<int> typeFenetre = new List<int>();
        public List<targetValidation> toutesMesFenetres;
        public int nombreColonne;
        public int nombreLigne;
        public int nombreBonneFenetre;
        public int fenetreRandom;


        // Start is called before the first frame update
        void Start()
        {

            for (int i = 0; i < nombreColonne; i++)
                for (int j = 0; j < nombreLigne; j++)
                {
                    typeFenetre.Add(fenetreRandom);

                    targetValidation fenetre =Instantiate(maFenetre, new Vector3(10.5f - i * 2, 8 - j*2, -0.5f), Quaternion.identity);
                    fenetre.numeroFenetre = i + j*i;
                    toutesMesFenetres.Add(fenetre);
                }
            var goodWindow = Random.Range(0, toutesMesFenetres.Count);
            toutesMesFenetres[goodWindow].isGood = true;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}

