using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor
{
    
    public class GenerateWindow : MonoBehaviour {

        public TargetValidation maFenetre;
        public List<int> typeFenetre = new List<int>();
        public List<TargetValidation> toutesMesFenetres;
        public int nombreColonne;
        public int nombreLigne;
        public int nombreBonneFenetre = 0;
        public int fenetreRandom;


        // Start is called before the first frame update
        void Start()
        {

            for (int i = 0; i < nombreColonne; i++)
            {
                for (int j = 0; j < nombreLigne; j++)
                {
                    typeFenetre.Add(fenetreRandom);

                    TargetValidation fenetre =Instantiate(maFenetre, new Vector3(12.5f - i * 4, 10.5f - j*4, -0.5f), Quaternion.identity);
                    fenetre.numeroFenetre = i + j*i;
                    toutesMesFenetres.Add(fenetre);
                }
            }
            while(nombreBonneFenetre != 3)
            {
                for (int y = 0; y < 3; y++)
                {
                    var goodWindow = Random.Range(0, toutesMesFenetres.Count);
                    if (toutesMesFenetres[goodWindow].isGood == false)
                    {
                        toutesMesFenetres[goodWindow].isGood = true;
                        nombreBonneFenetre += 1;
                    }

                }

            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}

