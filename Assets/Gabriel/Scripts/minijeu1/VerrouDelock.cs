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

        private bool didLeftInput, didRightInput, didUpInput, didDownInput;
        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < nombreVerrou; i++)
            {
                int verrouRandom = Random.Range(0, 5);
                sensVerrou.Add(verrouRandom);
                if (verrouRandom == 0)
                {
                    Instantiate(myVerrouBouton, new Vector3(2, 2 - i, -13), Quaternion.Euler(0, 180, 0));
                }
                else if (verrouRandom == 1)
                {
                    Instantiate(myVerrouDroite, new Vector3(2, 2 - i, -13), Quaternion.Euler(0, 180, 0));
                }
                else if (verrouRandom == 2)
                {
                    Instantiate(myVerrouGauche, new Vector3(2, 2 - i, -13), Quaternion.Euler(0, 180, 0));
                }
                else if (verrouRandom == 3)
                {
                    Instantiate(myVerrouHaut, new Vector3(2, 2 - i, -13), Quaternion.Euler(0, 180, 0));
                }
                else if (verrouRandom == 4)
                {
                    Instantiate(myVerrouBas, new Vector3(2, 2 - i, -13), Quaternion.Euler(0, 180, 0));
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (myVerrou >= nombreVerrou)
            {
                Debug.Log("T'es vraiment trop fort toi dit donc");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
        }

        public void VerrouCentre()
        {
            if (myVerrou < sensVerrou.Count)
            {
                if ((sensVerrou[myVerrou] == 0))
                {
                    transform.position += Vector3.down;
                    myVerrou++;
                }
            }
        }
        public void VerrouDroite()
        {
            if (myVerrou < sensVerrou.Count)
            {
                if ((sensVerrou[myVerrou] == 1) && (didRightInput == false))
                {
                    transform.position += Vector3.down;
                    myVerrou++;
                    didRightInput = true;
                }
            }
        }
        public void VerrouLeft()
        {
            if (myVerrou < sensVerrou.Count)
            {
                if ((sensVerrou[myVerrou] == 2) && (didLeftInput == false))
                {
                    transform.position += Vector3.down;
                    myVerrou++;
                    didLeftInput = true;
                }
            }
        }
        public void VerrouHaut()
        {
            if (myVerrou < sensVerrou.Count)
            {
                if ((sensVerrou[myVerrou] == 3) && (didUpInput == false))
                {
                    transform.position += Vector3.down;
                    myVerrou++;
                    didUpInput = true;
                }
            }
        }
        public void VerrouBas()
        {
            if (myVerrou < sensVerrou.Count)
            {
                if ((sensVerrou[myVerrou] == 4) && (didDownInput == false))
                {
                    transform.position += Vector3.down;
                    myVerrou++;
                    didDownInput = true;
                }
            }
        }

        public void ResetInputH()
        {
            didLeftInput = false;
            didRightInput = false;
        }
        public void ResetInputV()
        {
            didUpInput = false;
            didDownInput = false;
        }
    }
}
