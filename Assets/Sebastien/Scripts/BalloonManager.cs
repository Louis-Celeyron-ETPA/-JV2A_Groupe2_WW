using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Osborne
{

    public class BalloonManager : MonoBehaviour
    {
        int balloons = 0;
        [SerializeField] Text balloonsText;

        public void OnBalloonPop(string color)
        {
            if (color == "Green")
            {
                balloons++;
            }

            if (color == "Gold")
            {
                balloons *= 2;
            }

            if (color == "Red")
            {
                balloons--;
            }

            balloonsText.text = "BALLOONS:" + balloons;

        }

    }

}