using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Brandon;

public class InputTemporaire : MonoBehaviour
{

    public Voleur voleur;
    public Tapette tapette;
    public Door door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void VoleurDescending()
    {
        voleur.descending = true;
    }

    public void TapetteSlap()
    {
        tapette.slap = true;
    }

    public void TapetteUp()
    {
        tapette.upArrow = true;
    }

    public void TapetteDown()
    {
        tapette.downArrow = true;
    }

    public void TapetteRight()
    {
        tapette.rightArrow = true;
    }

    public void TapetteLeft()
    {
        tapette.leftArrow = true;
    }

    public void OpenDoor()
    {
        door.open = true;
    }
}
