using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor
{
    public class ScriptFeur : MonoBehaviour
    {
        public MeshRenderer mr1;
        public float timerFeur;
        public float timerReset;
        public bool isGood = false;
        public bool isFini = false;



        // Start is called before the first frame update
        void Start()
        {

            timerFeur = Random.Range(2f, 4f);

            mr1.material.color = new Color(1.0f, 0, 0);


            StartCoroutine(routine(timerFeur, timerReset));

        }

        // Update is called once per frame
        void Update()
        {

        }

        public IEnumerator routine(float timerFeur, float timerReset)
        {

            yield return new WaitForSeconds(timerFeur);
            mr1.material.color = new Color(0, 1.0f, 0);

            isGood = true;

            yield return new WaitForSeconds(timerFeur + timerReset);
            mr1.material.color = new Color(1.0f, 0, 0);

            isGood = false;

        }

        public void Action()
        {

            if (isGood == true && isFini == false)
            {
                Debug.Log("victoire");
                isFini = true;
            }

            if (isGood == false && isFini == false)
            {
                Debug.Log("defaite");
                isFini = true;
            }

        }
    }
}
