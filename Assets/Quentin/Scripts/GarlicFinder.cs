using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlicFinder : MonoBehaviour
{
   
    public int finded = 0;

    public Collider garlicCollider;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "feuille")
        {
            finded++;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
    }

    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "feuille")
        {
            finded--;
        }
    }

    void Update()
    {

       
        if (finded <= 0)
        {
            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
        }
    }
}
