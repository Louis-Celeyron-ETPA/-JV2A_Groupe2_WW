using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alexian
{
    public class Ending : MonoBehaviour
    {
        public Transform player;
        public Transform ennemy;
        public TextMeshProUGUI text;

        public GameObject UI;
        private bool isShowing;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void EndGame()
        {
            isShowing = true;
            UI.SetActive(isShowing);
            if (player.position.y > ennemy.position.y)
            {
                text.text = "Victoire";
            }
            else
            {
                text.text = "Défaite";
            }
        }
    }
}