using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor
{
    
    public class generateWindow : MonoBehaviour {

        public targetValidation maFenetre;
        public List<int> typeWindow = new List<int>();
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
                if(nombreBonneFenetre>0 )
                    {
                        fenetreRandom = Random.Range(0, 1);
                        nombreBonneFenetre -= 1;
                    }
                    else
                    {
                        fenetreRandom = 0;
                    }
                
                    typeWindow.Add(fenetreRandom);

                if(nombreBonneFenetre > 0 && i == 2 && j == 2)
                    {
                        fenetreRandom = 1;
                        nombreBonneFenetre -= 1;
                    }

                    targetValidation fenetre =Instantiate(maFenetre, new Vector3(10.5f - i * 2, 8 - j*2, -0.5f), Quaternion.identity);
                    fenetre.numeroFenetre = i + j*i;
                }
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerEnter(Collider other)
        {

            Debug.Log("coucou");
           
        }
    }

}

