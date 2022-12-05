using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMouton : MonoBehaviour
{
    public List<GameObject> bouttonMouton;
    public GameObject currentButton;
    // Start is called before the first frame update
    void Start()
    {
        currentButton = bouttonMouton[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectedButton()
    {
        if (currentButton == bouttonMouton[0])
        {
            currentButton = bouttonMouton[1];
        }
        else
        {
            currentButton = bouttonMouton[0];
        }
    }
}
