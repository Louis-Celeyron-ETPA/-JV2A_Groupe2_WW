using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace victor
{
    public class ScriptFeur : MonoBehaviour
    {
        [SerializeField]
        private MeshRenderer mr1;

        [SerializeField]
        private TimeManagerV time;

        private float timerFeur;
        private float timerReset;
        private bool isGood = false;
        private bool isComplete = false;
        private int stage = 3;
        private int currentStage = 0;
        private int fault = 4;
        private int currentFault = 0;
        private int valid = 3;
        private int currentValid = 0;

        // Start is called before the first frame update
        void Start()
        {
            stage = ManagerManager.DifficultyManager.GetDifficulty();
            mr1.material.color = new Color(1.0f, 0, 0);
            fault = fault- ManagerManager.DifficultyManager.GetDifficulty();
            valid = ManagerManager.DifficultyManager.GetDifficulty();
        }

        // Update is called once per frame
        void Update()
        {
            if (time.canMove == false)
            {
                while (currentStage != stage /*ManagerManager.DifficultyManager.GetDifficulty()*/)
                {
                    timerFeur = timerFeur + Random.Range(2f, 4f);
                    StartCoroutine(routine(timerFeur, timerReset));
                    currentStage += 1;
                }
            }   
        }

        public IEnumerator routine(float timerFeur, float timerReset)
        {
            yield return new WaitForSeconds(timerFeur);
            setColorGreen();
            yield return new WaitForSeconds(timerFeur + timerReset);
            setColorRed();
        }

        public void setColorRed()
        {
            mr1.material.color = new Color(1.0f, 0, 0);
            isGood = false;
        }
        public void setColorGreen()
        {
            mr1.material.color = new Color(0, 1.0f, 0);
            isGood = true;
        }

        public void Action()
        {
            if (isGood == true && isComplete == false)
            {
                Debug.Log("cc1");
                setColorRed();
                Debug.Log(currentValid);
                currentValid += 1;
            }

            if (isGood == false && isComplete == false)
            {
                Debug.Log("cc2");
                setColorRed();
                Debug.Log(currentFault);
                currentFault += 1;
            }

            if (valid == currentValid)
            {
                Debug.Log("cc3");
                time.isWin = true;
                isComplete = true;
            }
            if (fault == currentFault)
            {
                time.isLoose = true;
                isComplete = true;
            }
        }
    }
}
