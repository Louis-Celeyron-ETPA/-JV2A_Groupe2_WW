using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
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
        private List<GameObject> margoulist;
        private int rm;

        public int score;
        public TMP_Text textScore;
        public GameObject baptiste;
        public GameObject beer;
        public GameObject receiptUp;
        public GameObject receiptDown;
        public GameObject receiptLeft;

        public List<GameObject> gameObjectList;
        public List<ReceiptBeer> receiptToSpawnList;
        public BaptisteControl baptisteController;
        // Start is called before the first frame update
        void Start()
        {
            receiptToSpawnList = new List<ReceiptBeer>();
            gameObjectList = new List<GameObject>();
            rm = -1;

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
            margoulist = baptisteController.gameObjectList;

            if (rm != -1)
            {
                gameObjectList.RemoveAt(rm);
                rm = -1;
            }

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
            foreach (GameObject item in gameObjectList)
            {
                if (item != null)
                {
                    foreach (GameObject margou in margoulist)
                    {
                        if (margou != null)
                        {
                            if (item.transform.position.x > margou.transform.position.x - 0.3 && item.transform.position.x < margou.transform.position.x + 0.3 && item.transform.position.y > margou.transform.position.y - 0.7 && item.transform.position.y < margou.transform.position.y + 0.7)
                            {
                                {
                                    score += 200;
                                    rm = gameObjectList.IndexOf(item);
                                    Destroy(item);
                                }
                            }
                        }
                    }
                    if (item.transform.position.x > baptiste.transform.position.x - 0.3 && item.transform.position.x < baptiste.transform.position.x + 0.3 && item.transform.position.y > baptiste.transform.position.y - 0.7 && item.transform.position.y < baptiste.transform.position.y + 0.7)
                    {
                        score -= 1000;
                        rm = gameObjectList.IndexOf(item);
                        Destroy(item);
                    }
                    if (item.transform.position.x < -10)
                    {
                        score -= 100;
                        rm = gameObjectList.IndexOf(item);
                        Destroy(item);
                    }
                }
            }

            textScore.text = "" + score;
        }
    }
}
