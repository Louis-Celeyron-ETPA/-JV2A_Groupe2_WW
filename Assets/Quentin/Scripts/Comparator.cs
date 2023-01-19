using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quentin
{
    public class Comparator : MonoBehaviour
    {
        private bool game_over = false;
        public SpriteRenderer Wanted;
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(timeLeft());
        }

        IEnumerator timeLeft()
        {
            yield return new WaitForSeconds(7);

            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            
            if (collision.GetComponent<SpriteRenderer>().sprite.name == Wanted.sprite.name)
            {
            
                game_over = true;
            }
        }


        // Update is called once per frame
        void Update()
        {
            if (game_over == true)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }

        }
    }
}