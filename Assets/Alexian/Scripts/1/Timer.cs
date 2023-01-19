using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alexian
{
    public class Timer : MonoBehaviour
    {
        
        public Player player;
        public EnnemyInitialD ennemy;
        public SpriteRenderer sr;
        public Ending ending;
        public GameObject UI;

        private bool isShowing;
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(Launch());
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public IEnumerator Launch()
        {
            for (int i = 1; i < 4; i++)
            {
                yield return new WaitForSeconds(1);
                ending.text.text = i.ToString();
            }
            yield return new WaitForSeconds(1);
            ending.text.text = "Spam !";
            yield return new WaitForSeconds(1);
            UI.SetActive(false);
            sr.enabled = false;
            player.canMove = true;
            ennemy.canMove = true;
            isShowing = false;
            UI.SetActive(isShowing);
            Destroy(this);
        }
    }
}