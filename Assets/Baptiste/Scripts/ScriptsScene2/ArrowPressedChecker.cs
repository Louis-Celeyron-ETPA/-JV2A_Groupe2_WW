using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Baptiste;

namespace Baptiste {
    public class ArrowPressedChecker : MonoBehaviour
    {
        Scene2MainScript s1;
        public int score;
        public GameObject listArrowObject;
        public TMP_Text textScore;

        private float timeLastPressed;
        private float currentTime;
        private int rm;
        private List<GameObject> listArrowSpawn;
        // Start is called before the first frame update
        void Start()
        {
            timeLastPressed = 0f;
            rm = -1;
        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;
            s1 = listArrowObject.GetComponent<Scene2MainScript>();
            listArrowSpawn = s1.gameObjectList;

            score = int.Parse(textScore.text);

            if (rm != -1)
            {
                listArrowSpawn.RemoveAt(rm);
                rm = -1;
            }
        }

        public void checkOnPress()
        {
            if (currentTime - timeLastPressed > 0.2f)
            {
                timeLastPressed = currentTime;
                foreach (GameObject item in listArrowSpawn)
                {
                    if (item.transform.position.y > transform.position.y - 0.5 && item.transform.position.y < transform.position.y + 0.5 && item.transform.position.x == transform.position.x && item != null && rm == -1)
                    {
                        score = score + 500;
                        textScore.text = "" + score;
                        rm = listArrowSpawn.IndexOf(item);
                        Destroy(item);
                    }
                    else if (item.transform.position.y == -6f && item != null)
                    {
                        score = score - 1000;
                    }
                }
            }
        }
    }
}