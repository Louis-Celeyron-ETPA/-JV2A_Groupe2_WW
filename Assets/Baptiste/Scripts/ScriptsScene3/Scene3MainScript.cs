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
        private List<GameObject> projectileList;
        private int rm;
        private float randY;
        private bool sendReceiptLeft;
        
        public int ammo;
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
            sendReceiptLeft = false;

            receiptToSpawnList.Add(new ReceiptBeer(0, 5f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 6f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 7f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 8f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 9f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 10f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 11f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 12f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 13f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 14f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 15f));
            receiptToSpawnList.Add(new ReceiptBeer(0, 16f));

            receiptToSpawnList.Add(new ReceiptBeer(1, 6f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 7f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 8f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 9f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 10f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 11f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 12f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 13f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 14f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 15f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 16f));
            receiptToSpawnList.Add(new ReceiptBeer(1, 17f));

            receiptToSpawnList.Add(new ReceiptBeer(2, 1f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 1.5f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 2f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 2.5f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 3f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 3.5f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 4f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 4.5f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 5f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 5.5f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 6f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 6.5f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 7f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 7.5f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 8f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 8.5f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 9f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 9.5f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 10f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 10.5f));
            receiptToSpawnList.Add(new ReceiptBeer(2, 11f));

            receiptToSpawnList.Add(new ReceiptBeer(3, 5f));
            receiptToSpawnList.Add(new ReceiptBeer(3, 10f));
        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;
            projectileList = baptisteController.projectileList;

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
                    randY = Random.Range(-4.5f, 6f);
                    if (item.behavior == 0)
                    {
                        newObject = Instantiate(receiptUp);
                        gameObjectList.Add(newObject);
                        sendReceiptLeft = true;
                    }
                    else if (item.behavior == 1)
                    {
                        newObject = Instantiate(receiptDown);
                        gameObjectList.Add(newObject);
                        sendReceiptLeft = true;
                    }
                    else if (item.behavior == 2)
                    {
                        newObject = Instantiate(receiptLeft, new Vector3(14, randY, 0), Quaternion.identity);
                        gameObjectList.Add(newObject);
                    }
                    else if (item.behavior == 3)
                    {
                        newObject = Instantiate(beer, new Vector3(14, randY, 0), Quaternion.identity);
                        gameObjectList.Add(newObject);
                    }
                }
                if (sendReceiptLeft)
                {
                    newObject = Instantiate(receiptLeft, new Vector3(14, randY, 0), Quaternion.identity);
                    gameObjectList.Add(newObject);
                    sendReceiptLeft = false;
                }
            }
            foreach (GameObject item in gameObjectList)
            {
                if (item != null)
                {
                    foreach (GameObject projectile in projectileList)
                    {
                        if (projectile != null)
                        {
                            if (item.transform.position.x > projectile.transform.position.x - 0.4 && item.transform.position.x < projectile.transform.position.x + 0.4 && item.transform.position.y > projectile.transform.position.y - 0.8 && item.transform.position.y < projectile.transform.position.y + 0.8)
                            {
                                {
                                    if (item.name != "Beer(Clone)") {
                                        score += 200;
                                        rm = gameObjectList.IndexOf(item);
                                        Destroy(item);
                                        projectile.transform.position += Vector3.right * 10f;
                                    }
                                    else
                                    {
                                        projectile.transform.position += Vector3.right * 10f;
                                    }
                                }
                            }
                        }
                    }
                    if (item.transform.position.x > baptiste.transform.position.x - 0.3 && item.transform.position.x < baptiste.transform.position.x + 0.3 && item.transform.position.y > baptiste.transform.position.y - 0.7 && item.transform.position.y < baptiste.transform.position.y + 0.7)
                    {
                        if (item.name == "Beer(Clone)")
                        {
                            score += 500;
                            ammo = 15;
                            baptisteController.ammo = 15;
                            baptisteController.textAmmo.text = "x" + (ammo);
                        }
                        else
                        {
                            score -= 1000;
                            rm = gameObjectList.IndexOf(item);
                            Destroy(item);
                        }
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
