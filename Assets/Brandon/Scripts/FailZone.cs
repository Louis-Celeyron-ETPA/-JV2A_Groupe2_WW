using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Brandon
{
    public class FailZone : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Voleur voleurTriggered = collision.GetComponent<Voleur>();
            if (voleurTriggered != null)
            {
                voleurTriggered.gameOver = true;
            }

        }
    }
}

