using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Baptiste;

namespace Baptiste
{
    public class ArrowSpawn
    {
        public float appear;
        public string direction;
        public float disappear;
        public bool asAppeared;

        public ArrowSpawn(float newAppear, string newDirection, float newDisappear)
        {
            appear = newAppear;
            direction = newDirection;
            disappear = newDisappear;
            asAppeared = false;
        }
    }

    public class Scene2MainScript : MonoBehaviour
    {
        private GameObject newObject;

        public float currentTime;
        public GameObject arrowLeftFall;
        public GameObject arrowRightFall;
        public GameObject arrowUpFall;
        public GameObject arrowDownFall;

        public List<GameObject> gameObjectList;
        public List<ArrowSpawn> arrowToSpawnList;
        // Start is called before the first frame update
        void Start()
        {
            arrowToSpawnList = new List<ArrowSpawn>();
            gameObjectList = new List<GameObject>();
            

            arrowToSpawnList.Add(new ArrowSpawn(2f, "Left", 6f));
            /*arrowToSpawnList.Add(new ArrowSpawn(3f, "Right", 6f));
            arrowToSpawnList.Add(new ArrowSpawn(4f, "Left", 6f));
            arrowToSpawnList.Add(new ArrowSpawn(5f, "Right", 6f));
            arrowToSpawnList.Add(new ArrowSpawn(6f, "Left", 6f));
            arrowToSpawnList.Add(new ArrowSpawn(7f, "Right", 6f));*/
        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;

            foreach (ArrowSpawn item in arrowToSpawnList)
            {
                if (currentTime > item.appear && !item.asAppeared)
                {
                    item.asAppeared = true;
                    if (item.direction == "Left")
                    {
                        newObject = Instantiate(arrowLeftFall);
                        gameObjectList.Add(newObject);
                    }
                    else if (item.direction == "Right")
                    {
                        newObject = Instantiate(arrowRightFall);
                        gameObjectList.Add(newObject);
                    }
                    else if (item.direction == "Up")
                    {
                        newObject = Instantiate(arrowUpFall);
                        gameObjectList.Add(newObject);
                    }
                    else if (item.direction == "Down")
                    {
                        newObject = Instantiate(arrowDownFall);
                        gameObjectList.Add(newObject);
                    }
                }

            }

            foreach (GameObject item in gameObjectList)
            {
                item.transform.position -= Vector3.up * 0.05f;
            }
        }
    }
}