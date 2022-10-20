using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class VerrouDelock : MonoBehaviour
    {

        private List<int> sensVerrou = new List<int>();
        public int nombreVerrou;

        public GameObject myVerrouBouton;
        public GameObject myVerrouDroite;
        public GameObject myVerrouGauche;
        public GameObject myVerrouHaut;
        public GameObject myVerrouBas;
        private int myVerrou = 0;
        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < nombreVerrou; i++)
            {
                int verrouRandom = Random.Range(0, 5);
                sensVerrou.Add(verrouRandom);
                if (verrouRandom == 0)
                {
                    Instantiate(myVerrouBouton, new Vector3(2, 2 - i, -13), Quaternion.identity);
                }
                else if (verrouRandom == 1)
                {
                    Instantiate(myVerrouDroite, new Vector3(2, 2 - i, -13), Quaternion.identity);
                }
                else if (verrouRandom == 2)
                {
                    Instantiate(myVerrouGauche, new Vector3(2, 2 - i, -13), Quaternion.identity);
                }
                else if (verrouRandom == 3)
                {
                    Instantiate(myVerrouHaut, new Vector3(2, 2 - i, -13), Quaternion.identity);
                }
                else if (verrouRandom == 4)
                {
                    Instantiate(myVerrouBas, new Vector3(2, 2 - i, -13), Quaternion.identity);
                }
            }
        }

        // Update is called once per frame
        void Update()
        {   
            if (myVerrou < sensVerrou.Count)
            {

                if ((Input.GetKeyDown(KeyCode.Space)) && (sensVerrou[myVerrou] == 0))
                {
                    transform.position += Vector3.down;
                    myVerrou++;
                }

                if ((Input.GetKeyDown(KeyCode.RightArrow)) && (sensVerrou[myVerrou] == 1))
                {
                    transform.position += Vector3.down;
                    myVerrou++;
                }

                if ((Input.GetKeyDown(KeyCode.LeftArrow)) && (sensVerrou[myVerrou] == 2))
                {
                    transform.position += Vector3.down;
                    myVerrou++;
                }

                if ((Input.GetKeyDown(KeyCode.UpArrow)) && (sensVerrou[myVerrou] == 3))
                {
                    transform.position += Vector3.down;
                    myVerrou++;
                }

                if ((Input.GetKeyDown(KeyCode.DownArrow)) && (sensVerrou[myVerrou] == 4))
                {
                    transform.position += Vector3.down;
                    myVerrou++;
                }
            }
            
        }
    }
}
