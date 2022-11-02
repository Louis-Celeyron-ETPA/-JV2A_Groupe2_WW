using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moustique : MonoBehaviour
{
    public Transform moustique;
    public float speed = 0.1f;
    public Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = (new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f))).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        moustique.position += moustique.position * speed;
    }
}
