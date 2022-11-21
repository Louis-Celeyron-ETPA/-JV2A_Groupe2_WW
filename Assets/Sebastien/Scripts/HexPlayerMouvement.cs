using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{
    public class HexPlayerMouvement : MonoBehaviour
    {
        public float moveSpeed = 600f;
        float mouvement = 0f;

        public GameObject player;

        // Update is called once per frame
        void Update()
        {
            mouvement = Input.GetAxisRaw("Horizontal");
        }

        private void FixedUpdate()
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, mouvement * Time.deltaTime * -moveSpeed);
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
      
            if (collision.gameObject.CompareTag("Hexagon"))
            {
                Destroy(collision.transform.gameObject);
                Debug.Log("test");

            }
        }

    }
}
