using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quentin
{

    public class Collision : MonoBehaviour

    {
        public bool gameOver;
        // Start is called before the first frame update
        void Start()
        {
            gameOver = false;
            StartCoroutine(timeAlive());
        }

        IEnumerator timeAlive()
        {
            yield return new WaitForSeconds(7);

            if (gameOver == false)
            {
                Debug.Log("c'est vraiment gagné");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            else if (gameOver =! false)
            {
                Debug.Log("c'est vraiment perdu");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }



        // Update is called once per frame
        void Update()
        {

            if (gameOver == true)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Bomb")
            {
                gameOver = true;
            }
        }


    }
}
