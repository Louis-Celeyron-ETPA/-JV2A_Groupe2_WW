using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timerdanger : MonoBehaviour
{
    public float timeRemaining = 3;
    public bool timerIsRunning = false;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }
    void Update()
    {
        {
            {
                if (Input.GetKey(KeyCode.D))
                {
                    Destroy(GameObject.FindWithTag("GameOver"));
                    GameObject.FindWithTag("Success").SetActive(true);


                }
            }
        }

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }

            else
            {
                Debug.Log("limite de temps");
                timeRemaining = 0;
                timerIsRunning = false;
                Destroy(gameObject);
                GameObject.FindWithTag("GameOver").SetActive(true);
                ManagerManager.GlobalGameManager.EndOfMinigame(MiniGameRating.Fail);
            }
        }
    }
}