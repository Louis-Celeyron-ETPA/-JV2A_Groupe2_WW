using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class verrouDelock : MonoBehaviour
    {

        private List<int> sensVerrou = new List<int>();

        public GameObject myVerrouDroite;
        public GameObject myVerrouGauche;
        private int myVerrou = 0;
        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < 4; i++)
            {
                int verrouRandom = Random.Range(1, 3);
                sensVerrou.Add(verrouRandom);
                if (verrouRandom == 1)
                {
                    Instantiate(myVerrouDroite, new Vector3(2, 2 - i, -13), Quaternion.identity);
                }
                else if (verrouRandom == 2)
                {
                    Instantiate(myVerrouGauche, new Vector3(2, 2 - i, -13), Quaternion.identity);
                }
            }
        }

        // Update is called once per frame
        void Update()
        {   
            if (myVerrou < sensVerrou.Count)
            {
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
            }
            
        }
    }
}
