using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public CensoredObject censoredObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void click()
    {
        var rectTransform = (transform as RectTransform);
        var positionTemporaire = new Vector3(
            rectTransform.anchoredPosition.x / Camera.main.pixelWidth,
            rectTransform.anchoredPosition.y / Camera.main.pixelHeight * -1,
            Camera.main.nearClipPlane);
        var convertedPosition = Camera.main.ViewportToWorldPoint(positionTemporaire);

        var positionDansLeMonde = new Vector3(convertedPosition.x, -convertedPosition.y, convertedPosition.z);

        if (Physics.Raycast(positionDansLeMonde, Camera.main.transform.forward, out var info))
        {
            var censoredWindow = info.transform.GetComponent<CensoredObject>();
            if (censoredWindow != null)
            {
                censoredObject.isMoving = true;
                if(censoredObject.firstClick == false)
                {
                    censoredObject.firstClick = true;
                }
                else
                {
                    censoredObject.firstClick = false;
                    censoredObject.positionObject.position = positionDansLeMonde;
                }
            }
        }
    }
}