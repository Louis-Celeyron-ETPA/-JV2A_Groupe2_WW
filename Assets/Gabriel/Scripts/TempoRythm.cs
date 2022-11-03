using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempoRythm : MonoBehaviour
{

    public float vitesseRythm;
    public int tempoState;
    public MeshRenderer mr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * vitesseRythm;
    }

    public void RythmCheck()
    {
        if (tempoState == 1)
        {
            mr.enabled = false;
        }
    }
}
