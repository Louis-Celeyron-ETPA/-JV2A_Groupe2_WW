using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class VerrouDelock : MonoBehaviour
    {
        private List<int> sensVerrou = new List<int>();
        public int nombreVerrou;

        public GameObject myVerrouPrefab;
        public List<Sprite> mesSprites;
        public List<Sprite> mesSpritesB;

        public List<GameObject> mesVerrous;
        private int myVerrou = 0;

        private bool didLeftInput, didRightInput, didUpInput, didDownInput;

        public Vector3 currentCameraPosition;
        public Vector3 nextCameraPosition;
        public float deplacementCamera;

        [SerializeField]
        private Transform monAnnonce;
        // Start is called before the first frame update
        void Start()
        {
            nombreVerrou += ManagerManager.DifficultyManager.GetDifficulty();
            //c'est fait exprès si ça dépasse sur le sol*

            for (float i = 0; i < nombreVerrou; i++)
            {
                int verrouRandom = Random.Range(0, 5);
                sensVerrou.Add(verrouRandom);
                var monVerrou = Instantiate(myVerrouPrefab, new Vector3(2.2f, 2f - i / 1.5f, -15), Quaternion.Euler(0, 180, 0));
                monVerrou.GetComponent<SpriteRenderer>().sprite = mesSprites[verrouRandom];
                mesVerrous.Add(monVerrou);
            }
        }

        // Update is called once per frame
        void Update()
        {
            monAnnonce.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, -18);
            if (deplacementCamera < 1)
            {
                Camera.main.transform.position = Vector3.Lerp(currentCameraPosition, nextCameraPosition, deplacementCamera);
                if (myVerrou == 0)
                {
                    deplacementCamera += 0.01f;
                }
                else
                {
                    deplacementCamera += 0.05f;
                }
            }
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
                    currentCameraPosition = nextCameraPosition;
                    nextCameraPosition += Vector3.down / 1.5f;
                    deplacementCamera = 0;
                    mesVerrous[myVerrou].GetComponent<SpriteRenderer>().sprite = mesSpritesB[sensVerrou[myVerrou]];
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
                    currentCameraPosition = nextCameraPosition;
                    nextCameraPosition += Vector3.down / 1.5f;
                    deplacementCamera = 0;
                    mesVerrous[myVerrou].GetComponent<SpriteRenderer>().sprite = mesSpritesB[sensVerrou[myVerrou]];
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
                    currentCameraPosition = nextCameraPosition;
                    nextCameraPosition += Vector3.down / 1.5f;
                    deplacementCamera = 0;
                    mesVerrous[myVerrou].GetComponent<SpriteRenderer>().sprite = mesSpritesB[sensVerrou[myVerrou]];
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
                    currentCameraPosition = nextCameraPosition;
                    nextCameraPosition += Vector3.down / 1.5f;
                    deplacementCamera = 0;
                    mesVerrous[myVerrou].GetComponent<SpriteRenderer>().sprite = mesSpritesB[sensVerrou[myVerrou]];
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
                    currentCameraPosition = nextCameraPosition;
                    nextCameraPosition += Vector3.down / 1.5f;
                    deplacementCamera = 0;
                    mesVerrous[myVerrou].GetComponent<SpriteRenderer>().sprite = mesSpritesB[sensVerrou[myVerrou]];
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
