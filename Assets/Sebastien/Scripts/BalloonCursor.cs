using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{

    public class BalloonCursor : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.anyKeyDown)
            {
                var rectTransform = (transform as RectTransform);
                var positionTemporaire = new Vector3(
                    rectTransform.anchoredPosition.x / Camera.main.pixelWidth,
                    rectTransform.anchoredPosition.y / Camera.main.pixelHeight * -1,
                    Camera.main.nearClipPlane);
                var convertedPosition = Camera.main.ViewportToWorldPoint(positionTemporaire);

                var positionDansLeMonde = new Vector3(convertedPosition.x, - convertedPosition.y, convertedPosition.z);

                if (Physics.Raycast(positionDansLeMonde, Camera.main.transform.forward, out var info))
                {
                    var ball = info.transform.GetComponent<BalloonCollector>();
                    if (ball != null)
                    {
                        //Debug.Log(ball);
                    }
                }
            }
        }
    }
}
