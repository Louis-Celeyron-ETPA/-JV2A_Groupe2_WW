using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// l'idée était de cliquer au bon moment après un enchainement d'image, pour que le joueur "bloque" l'ennemi. type mini jeu "Samurai Kirby" de Kirby super star. faire disparaitre les images est possible mais le code ne peut être terminer de cette façon.
// Les images placeholders de couleurs n'apparaissent pas? impossible de me concentrer sur les images finals si le code ne marche pas.
public class Timerneutre : MonoBehaviour
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