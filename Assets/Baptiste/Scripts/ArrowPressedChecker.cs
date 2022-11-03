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

        private List<GameObject> listArrowSpawn;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            s1 = listArrowObject.GetComponent<Scene2MainScript>();
            listArrowSpawn = s1.gameObjectList; 
        }

        public void checkOnPress()
        {
            foreach (GameObject item in listArrowSpawn)
            {
                if (item.transform.position.y > transform.position.y - 2 && item.transform.position.y < transform.position.y + 2 && item.transform.position.x == transform.position.x)
                {
                    Debug.Log("" + item.transform.position);
                }
            }
        }
    }
}
