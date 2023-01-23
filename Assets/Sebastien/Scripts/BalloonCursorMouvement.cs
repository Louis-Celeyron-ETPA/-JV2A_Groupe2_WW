using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Osborne
{
    public class BalloonCursorMouvement : MonoBehaviour
    {

        private GameObject myBalloon;
        public BalloonManager balloonManager;
        public int balloons = 0;

        [SerializeField] Text balloonsText;
        [SerializeField] AudioSource popSound;
        [SerializeField] float speed = 1f;


        private void Start()
        {
           PlayerPrefs.SetString("currentScore", "0");
        }



        void Update()
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);

            var myRay = new Ray(transform.position, Vector3.forward);
            if (Physics.Raycast(myRay, out var other))
            {
                if (other.collider.GetComponent<BalloonCollector>() != null)
                {
                    myBalloon = other.collider.GetComponent<Transform>().gameObject;
                }
                else
                {
                    myBalloon = null;
                }
            }

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9.5f, 8.5f), Mathf.Clamp(transform.position.y, -4, 6), transform.position.z);
        }


        public void BalloonHit()
        {
            if (myBalloon != null)
            {
                Destroy(myBalloon);
                balloonManager.OnBalloonPop(myBalloon.tag);
                popSound.Play();

                if (balloons == 20)
                {
                    PlayerPrefs.SetString("currentScore", balloonsText.text);
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                }
                else if (myBalloon.tag == "Red")
                {
                    Debug.Log("Failed");
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                    ManagerManager.LifeManager.GetCurrentLife();
                    ManagerManager.DifficultyManager.GetDifficulty();
                }
            }

        }

    }

}
