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
        public bool asAppeared;

        public ArrowSpawn(float newAppear, string newDirection)
        {
            appear = newAppear;
            direction = newDirection;
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
            
            //MaxScore = 15000
            arrowToSpawnList.Add(new ArrowSpawn(2f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(3f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(4f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(5f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(6f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(7f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(8f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(9f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(10f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(11f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(12f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(13f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(14f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(15f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(16f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(17f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(18f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(19f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(20f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(21f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(22f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(23f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(24f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(25f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(26f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(27f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(28f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(29f, "Right"));
            arrowToSpawnList.Add(new ArrowSpawn(30f, "Left"));
            arrowToSpawnList.Add(new ArrowSpawn(31f, "Right"));
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