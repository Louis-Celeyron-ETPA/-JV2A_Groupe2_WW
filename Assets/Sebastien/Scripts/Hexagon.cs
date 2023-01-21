using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
    public class Hexagon : MonoBehaviour
    {
        public Rigidbody2D rb;
        public float shrinkSpeed = 1f;
        public bool isGood = false;


        // Start is called before the first frame update
        void Start()
        {
            rb.rotation = Random.Range(0f, 360f);
            transform.localScale = Vector3.one * 5f;
        }
        // Update is called once per frame
        void Update()
        {
            transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
            if (transform.localScale.x <= 0.05f)
            {
                Destroy(gameObject);
                
                if (isGood == true)
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                }
                else
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                    ManagerManager.LifeManager.GetCurrentLife();
                    ManagerManager.DifficultyManager.GetDifficulty();
                }
            }

        }
    }
}
