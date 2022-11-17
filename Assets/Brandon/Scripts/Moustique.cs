using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moustique : MonoBehaviour
{
    public Transform moustique;
    public float speed = 0.1f;
    public float radius = 20;
    public Vector2 direction;
    private Vector2 positionInitiale;

    // Start is called before the first frame update
    void Start()
    {
        LaunchMovement();
    }

    // Update is called once per frame
    void Update()
    {
        moustique.position = Vector2.MoveTowards(moustique.position, direction, speed);   
        if(Vector3.Distance(direction, moustique.position)<=0.1f)
        {
            LaunchMovement();
        }
    }

    private void LaunchMovement()
    {
        direction = Random.insideUnitSphere * 20;
        positionInitiale = moustique.position;
    }
}
