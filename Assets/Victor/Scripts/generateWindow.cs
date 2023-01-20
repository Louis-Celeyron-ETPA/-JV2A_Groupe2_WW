using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor
{
    
    public class GenerateWindow : MonoBehaviour {

        public TargetValidation maFenetre;
        //private List<int> typeFenetre = new List<int>();
        public List<TargetValidation> toutesMesFenetres; //Must stay on public

        [SerializeField]
        private int nombreColonne = 3;

        [SerializeField]
        private int nombreLigne = 3;


        public int nombreBonneFenetre = 0;

        // Start is called before the first frame update
        void Start()
        {

            for (int i = 0; i < this.nombreColonne; i++) //generate 9 window square
            {
                for (int j = 0; j < this.nombreLigne; j++)
                {

                    TargetValidation fenetre = Instantiate(maFenetre, new Vector3(12.5f - i * 4, 10.5f - j*4, -0.5f), Quaternion.identity);
                    fenetre.numeroFenetre = i + (j* nombreLigne);
                    toutesMesFenetres.Add(fenetre);
                }
            }

            
            while (nombreBonneFenetre != 3)//draw 3 random window from the 9 window cube set them in to a target
            {
                for (int y = 0; y < 3; y++)
                {
                    var goodWindow = Random.Range(0, this.toutesMesFenetres.Count);
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

