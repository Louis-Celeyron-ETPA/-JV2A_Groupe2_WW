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
        private int difficulty;
        private bool end;
        private GameObject newObject;

        public float currentTime;
        public GameObject arrowLeftFall;
        public GameObject arrowRightFall;
        public GameObject arrowUpFall;
        public GameObject arrowDownFall;
        public ArrowPressedChecker myArrowPressedChecker;

        public List<GameObject> gameObjectList;
        public List<ArrowSpawn> arrowToSpawnList;
        // Start is called before the first frame update
        void Start()
        {
            end = false;
            difficulty = ManagerManager.DifficultyManager.GetDifficulty();
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

            if (difficulty > 1)
            {
                arrowToSpawnList.Add(new ArrowSpawn(2.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(3.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(4.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(5.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(6.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(7.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(8.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(9.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(10.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(11.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(12.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(13.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(14.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(15.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(16.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(17.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(18.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(19.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(20.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(21.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(22.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(23.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(24.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(25.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(26.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(27.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(28.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(29.5f, "Left"));
                arrowToSpawnList.Add(new ArrowSpawn(30.5f, "Right"));
                arrowToSpawnList.Add(new ArrowSpawn(31.5f, "Left"));
            }
            if (difficulty > 2)
            {
                //There might be some bug when on the highest difficulty level, it comes down to the way I handle the list in the ArrowPressedChecker script,
                //I would have resolved it but it's a bug that only happen on the school computers, so I'm at a bit of a loss
                arrowToSpawnList.Add(new ArrowSpawn(2.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(3.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(4.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(5.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(6.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(7.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(8.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(9.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(10.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(11.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(12.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(13.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(14.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(15.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(16.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(17.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(18.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(19.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(20.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(21.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(22.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(23.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(24.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(25.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(26.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(27.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(28.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(29.25f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(30.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(31.25f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(2.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(3.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(4.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(5.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(6.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(7.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(8.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(9.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(10.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(11.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(12.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(13.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(14.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(15.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(16.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(17.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(18.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(19.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(20.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(21.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(22.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(23.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(24.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(25.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(26.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(27.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(28.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(29.75f, "Up"));
                arrowToSpawnList.Add(new ArrowSpawn(30.75f, "Down"));
                arrowToSpawnList.Add(new ArrowSpawn(31.75f, "Down"));
            }
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
                if (item != null)
                {
                    item.transform.position -= Vector3.up * 0.05f;
                }
            }

            if (currentTime > 34f)
            {
                if (difficulty == 1)
                {
                    if (myArrowPressedChecker.score < 5000)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                    }
                    else if (myArrowPressedChecker.score > 12000)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
                    }
                    else
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                    }
                }
                else if (difficulty == 2)
                {
                    if (myArrowPressedChecker.score < 10000)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                    }
                    else if (myArrowPressedChecker.score > 24000)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
                    }
                    else
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                    }
                }
                else
                {
                    if (myArrowPressedChecker.score < 30000)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                    }
                    else if (myArrowPressedChecker.score > 55000)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
                    }
                    else
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                    }
                }
            }
        }
    }
}