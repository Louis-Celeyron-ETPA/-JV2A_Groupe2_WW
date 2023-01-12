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

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            
            Debug.Log("c'est une tete");
            if (collision.GetComponent<SpriteRenderer>().sprite.name == Wanted.sprite.name)
            {
                Debug.Log("c'est une tete");
                game_over = true;
            }
        }


        // Update is called once per frame
        void Update()
        {
            if (game_over == true)
            {
                Debug.Log("C'est fini");
            }
        }
    }
}