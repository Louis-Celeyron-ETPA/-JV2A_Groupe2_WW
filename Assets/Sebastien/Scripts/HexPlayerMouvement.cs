using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HexPlayerMouvement : MonoBehaviour
{
    public float moveSpeed = 600f;

    float mouvement = 0f;

    // Update is called once per frame
    void Update()
    {
        mouvement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, mouvement * Time.fixedDeltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
