using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alexian
{
    public class Timer : MonoBehaviour
    {
        public float currentTime;
        public float timeMax;
        public Player player;
        public EnnemyInitialD ennemy;
        public SpriteRenderer sr;

        public Ending ending;

        public GameObject UI;
        private bool isShowing;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;
            if (currentTime >= timeMax)
            {
                sr.enabled = false;
                player.canMove = true;
                ennemy.canMove = true;
                isShowing = false;
                UI.SetActive(isShowing);
                Destroy(this);
            }
            if (currentTime > 1)
            {
                ending.text.text = "1";
            }
            if (currentTime > 2)
            {
                ending.text.text = "2";
            }
            if (currentTime > 3)
            {
                ending.text.text = "3";
            }
            if (currentTime > 4)
            {
                ending.text.text = "Spam !";
            }
        }
    }
}