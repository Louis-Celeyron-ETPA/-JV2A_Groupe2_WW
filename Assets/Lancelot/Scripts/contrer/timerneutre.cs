using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class timerneutre : MonoBehaviour
{
    public float timeRemaining = 10;
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
                    Destroy(GameObject.FindWithTag("defaite"));
          
                    GameObject.FindWithTag("GameOver").SetActive(true);


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
            }
        }
    }
}