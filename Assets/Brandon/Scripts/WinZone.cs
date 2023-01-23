using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Brandon
{


    public class WinZone : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Treasure TreasureTriggered = collision.GetComponent<Treasure>();
            if (TreasureTriggered != null)
            {
               
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                
            }

        }
    }
}
