using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
    public class PaddleGoal : MonoBehaviour
    {
        public bool ballerGoal;

        private void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                if (!ballerGoal)
                {
                    Debug.Log("Well Done, You Scored ! I guess you arn't a complete failure after all ");
                    // GameObject.Find("GameManager").GetComponent<PaddleManager>().PlayerScored();
                }
            }
        }
    }

}
