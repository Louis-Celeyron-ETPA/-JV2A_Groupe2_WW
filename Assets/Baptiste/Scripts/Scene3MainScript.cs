using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Baptiste;

namespace Baptiste
{
    public class Scene3MainScript : MonoBehaviour
    {
        public float currentTime;

        public class ReceiptBeer
        {
            public int behavior;
            public float timeSpawn;
            public bool asAppeared;

            public ReceiptBeer(int newBehavior, float newTimeSpawn)
            {
                behavior = newBehavior;
                timeSpawn = newTimeSpawn;
                asAppeared = false;
            }
        }
        private GameObject newObject;

        public GameObject beer;
        public GameObject receiptUp;
        public GameObject receiptDown;
        public GameObject receiptLeft;

        public List<GameObject> gameObjectList;
        public List<ReceiptBeer> receiptToSpawnList;
        // Start is called before the first frame update
        void Start()
        {
            receiptToSpawnList = new List<ReceiptBeer>();
            gameObjectList = new List<GameObject>();


            receiptToSpawnList.Add(new ReceiptBeer(0, 0.5f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 1f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 1.5f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 2f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 2.5f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 3f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 3.5f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 4f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 4.5f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 5f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 5.5f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 6f));

            receiptToSpawnList.Add(new ReceiptBeer(1, 0.5f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 1f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 1.5f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 2f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 2.5f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 3f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 3.5f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 4f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 4.5f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 5f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 5.5f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 6f));
        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;

            foreach (ReceiptBeer item in receiptToSpawnList)
            {
                if (currentTime > item.timeSpawn && !item.asAppeared)
                {
                    item.asAppeared = true;
                    if (item.behavior == 0)
                    {
                        newObject = Instantiate(receiptUp);
                        gameObjectList.Add(newObject);
                    }
                    else if (item.behavior == 1)
                    {
                        newObject = Instantiate(receiptDown);
                        gameObjectList.Add(newObject);
                    }
                    else if (item.behavior == 2)
                    {
                        newObject = Instantiate(receiptLeft);
                        gameObjectList.Add(newObject);
                    }
                    else if (item.behavior == 3)
                    {
                        newObject = Instantiate(beer);
                        gameObjectList.Add(newObject);
                    }
                }

            }
        }
    }
}
